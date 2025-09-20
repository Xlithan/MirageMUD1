using MirageMUD.Server.Config;
using MirageMUD.Shared.Networking;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

namespace MirageMUD.Server.Networking
{
    public sealed class ServerTcp
    {
        private readonly TcpListener _listener;
        private readonly ConcurrentDictionary<int, ClientConnection> _clients = new();
        private int _nextClientId = 1;

        public ServerTcp(ServerConfig config)
        {
            var ip = IPAddress.Parse(config.ListenIp);
            _listener = new TcpListener(ip, config.Port);
        }

        public void Start()
        {
            _listener.Start();
            Console.WriteLine($"[ServerTcp] Listening on {_listener.LocalEndpoint}");
            _ = AcceptLoop();
        }

        private async Task AcceptLoop()
        {
            while (true)
            {
                TcpClient tcpClient = await _listener.AcceptTcpClientAsync();
                int clientId = _nextClientId++;
                var conn = new ClientConnection(clientId, tcpClient);

                if (_clients.TryAdd(clientId, conn))
                {
                    Console.WriteLine($"[ServerTcp] Client {clientId} connected from {tcpClient.Client.RemoteEndPoint}");
                    conn.StartReceiveLoop(RemoveClient);
                }
            }
        }

        private void RemoveClient(int id)
        {
            if (_clients.TryRemove(id, out _))
            {
                Console.WriteLine($"[ServerTcp] Client {id} disconnected");
            }
        }
    }

    internal sealed class ClientConnection
    {
        private readonly TcpClient _tcpClient;
        private readonly NetworkStream _stream;
        private readonly PacketBuffer _buffer = new();

        public int Id { get; }

        public ClientConnection(int id, TcpClient client)
        {
            Id = id;
            _tcpClient = client;
            _stream = client.GetStream();
        }

        public void StartReceiveLoop(Action<int> onDisconnect)
        {
            _ = Task.Run(async () =>
            {
                byte[] recv = new byte[4096];

                try
                {
                    while (true)
                    {
                        int bytes = await _stream.ReadAsync(recv, 0, recv.Length);
                        if (bytes == 0) break; // client disconnected

                        _buffer.Append(recv, bytes);

                        while (_buffer.HasPackets)
                        {
                            var raw = _buffer.PopPacket();
                            using var reader = new PacketReader(raw);
                            Console.WriteLine($"[ServerTcp] Received packet {reader.Id} from client {Id}");
                            // TODO: hand off to DataHandler
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ServerTcp] Error with client {Id}: {ex.Message}");
                }
                finally
                {
                    onDisconnect(Id);
                }
            });
        }
    }
}