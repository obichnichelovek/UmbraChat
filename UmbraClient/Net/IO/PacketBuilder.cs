using System.IO;
using System.Text;

namespace UmbraClient.Net.IO;

internal sealed class PacketBuilder
{
    private readonly MemoryStream ms;

    public PacketBuilder()
    {
        ms = new();
    }

    public void WriteUpcode(byte opcode) { ms.WriteByte(opcode); }
    public void WriteMessage(string message)
    {
        int length = message.Length;
        ms.Write(BitConverter.GetBytes(length));
        ms.Write(Encoding.UTF8.GetBytes(message));
    }
    public byte[] GetPacketBytes() { return ms.ToArray(); }
}