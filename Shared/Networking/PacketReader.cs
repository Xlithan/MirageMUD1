using System;
using System.IO;
using System.Text;

namespace MirageMUD.Shared.Networking
{
    public class PacketReader : IDisposable
    {
        private readonly MemoryStream _stream;
        private readonly BinaryReader _reader;

        public int Length { get; }
        public int Id { get; }

        public PacketReader(byte[] data)
        {
            _stream = new MemoryStream(data);
            _reader = new BinaryReader(_stream, Encoding.UTF8, true);

            Length = _reader.ReadInt32();
            Id = _reader.ReadInt32();
        }

        public int ReadInt() => _reader.ReadInt32();
        public string ReadString() => _reader.ReadString();
        public bool ReadBool() => _reader.ReadBoolean();
        public byte ReadByte() => _reader.ReadByte();
        public byte[] ReadBytes() => _reader.ReadBytes(_reader.ReadInt32());

        public void Dispose()
        {
            _reader.Dispose();
            _stream.Dispose();
        }
    }
}