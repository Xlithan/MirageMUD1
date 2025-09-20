using System;

namespace MirageMUD.Shared.Networking
{
    public class Packet
    {
        public int Id { get; }
        public byte[] Data { get; }

        public Packet(int id, byte[] data)
        {
            Id = id;
            Data = data ?? Array.Empty<byte>();
        }
    }
}