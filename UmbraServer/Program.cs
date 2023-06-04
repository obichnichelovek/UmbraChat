using System.Net;
using System.Net.Sockets;
using System.Text;
using UmbraServer.Net.IO;

namespace UmbraServer;

internal partial class Program
{
    private static List<Client> users = new();
    static readonly TcpListener listener = new(IPAddress.Parse("192.168.100.7"), 8080);

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        listener.Start();

        Client.Notification("Server started", null!, ConsoleColor.Green);

        while (true)
        {
            Client client = new(listener.AcceptTcpClient());
            users.Add(client);

            BroadcastConnection();
        }
    }

    private static void BroadcastConnection()
    {
        foreach (var x in users)
        {
            foreach (var y in users)
            {
                PacketBuilder broadcastPacket = new();
                broadcastPacket.WriteUpcode(1);
                broadcastPacket.WriteMessage(y.Username);
                broadcastPacket.WriteMessage(y.UID.ToString());

                x.ClientSocket.Client.Send(broadcastPacket.GetPacketBytes());
            }
        }
    }

    public static void BroadcastMessage(string message)
    {
        foreach (var user in users)
        {
            PacketBuilder messagePacket = new();
            messagePacket.WriteUpcode(5);
            messagePacket.WriteMessage(message);

            user.ClientSocket.Client.Send(messagePacket.GetPacketBytes());
        }
    }

    public static void BroadcastDisconnect(string uid)
    {
        var disconnectedUser = users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
        users.Remove(disconnectedUser!);

        foreach (var user in users)
        {
            PacketBuilder broadcastPacket = new();
            broadcastPacket.WriteUpcode(10);
            broadcastPacket.WriteMessage(uid);

            user.ClientSocket.Client.Send(broadcastPacket.GetPacketBytes());
        }
        BroadcastMessage($"{disconnectedUser!.Username} disconnected");
    }
}