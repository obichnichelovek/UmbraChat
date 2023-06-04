using System.IO;
using System.Net.Sockets;
using System.Text;

namespace UmbraClient.Net.IO;

internal sealed class PacketReader : BinaryReader
{
    private readonly NetworkStream ns;

    public PacketReader(NetworkStream ns) : base(ns)
    {
        this.ns = ns;
    }

    public string ReadMessage()
    {
        var length = ReadInt32();
        var buffer = new byte[length];

        ns.Read(buffer, 0, length);

        return Encoding.UTF8.GetString(buffer);
    }
}