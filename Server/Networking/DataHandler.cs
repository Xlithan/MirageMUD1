using Server.Networking;
using System.Text;
using Server.Database;
using Shared.Networking;
using Server.Game;
using System;
using System.Text.Json;

namespace Server.Networking
{
    public sealed class DataHandler
    {
        private readonly ServerGameLogic _logic;
        private readonly ServerTcp _tcp;

        public DataHandler(ServerGameLogic logic, ServerTcp tcp)
        {
            _logic = logic;
            _tcp = tcp;
        }

        public void HandlePacket(int clientId, ClientPacketId packetId, ReadOnlySpan<byte> payload)
        {
            switch (packetId)
            {
                case ClientPacketId.CSync:
                    {
                        _tcp.SendSync(clientId, "pong");
                        break;
                    }

                case ClientPacketId.CLogin:
                    {
                        var req = System.Text.Json.JsonSerializer.Deserialize<LoginRequestDto>(payload)!;
                        var res = _logic.HandleLogin(req);

                        _tcp.SendLoginOk(clientId, res.Success, res.Message ?? "", res.AccountId ?? "");
                        if (res.Success && res.AccountId is not null)
                        {
                            _tcp.SetAccount(clientId, res.AccountId);
                            var chars = _logic.GetCharacters(res.AccountId);   // small helper we’ll add next
                            _tcp.SendAllChars(clientId, chars);
                        }
                        break;
                    }

                case ClientPacketId.CUseChar:
                    {
                        var charId = Encoding.UTF8.GetString(payload);
                        if (!_tcp.TryGetAccount(clientId, out var accountId) || accountId is null)
                        {
                            _tcp.SendAlert(clientId, "Not logged in.");
                            break;
                        }

                        if (!_logic.CharacterBelongsTo(accountId, charId))
                        {
                            _tcp.SendAlert(clientId, "That character is not yours.");
                            break;
                        }

                        _tcp.SetCharacter(clientId, charId);

                        // Enter game (for now just signal SInGame; you’ll follow with player data next)
                        _tcp.SendInGame(clientId);
                        break;
                    }

                case ClientPacketId.CDelChar:
                    {
                        var charId = Encoding.UTF8.GetString(payload);
                        if (!_tcp.TryGetAccount(clientId, out var accountId) || accountId is null)
                        {
                            _tcp.SendAlert(clientId, "Not logged in.");
                            break;
                        }

                        if (!_logic.DeleteCharacter(accountId, charId))
                        {
                            _tcp.SendAlert(clientId, "Delete failed.");
                            break;
                        }

                        var list = _logic.GetCharacters(accountId);
                        _tcp.SendAllChars(clientId, list); // refresh list
                        break;
                    }
            }
        }
    }
}