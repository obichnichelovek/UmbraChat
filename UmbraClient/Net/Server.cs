using System.Net.Sockets;
using System.Text;
using UmbraClient.Net.IO;

namespace UmbraClient.Net;

internal class Server
{
    private readonly TcpClient client;

    public PacketReader PacketReader = null!;

    public event Action ConnectedEvent = null!;
    public event Action MessageReceivedEvent = null!;
    public event Action UserDisconnectEvent = null!;

    public Server()
    {
        client = new();
    }

    public void ConnectToServer(string username)
    {
        if (!client.Connected)
        {
            client.Connect("192.168.100.7", 8080);

            if (!string.IsNullOrEmpty(username))
            {
                PacketReader = new(client.GetStream());
                PacketBuilder connectPacket = new();

                connectPacket.WriteUpcode(0);
                connectPacket.WriteMessage(username);
                client.Client.Send(connectPacket.GetPacketBytes());
            }
            ReadPackets();
        }

    }

    private void ReadPackets()
    {
        Task.Run(() =>
        {
            while (true)
            {
                var opcode = PacketReader.ReadByte();
                switch (opcode)
                {
                    case 1:
                        ConnectedEvent?.Invoke();
                        break;
                    case 5:
                        MessageReceivedEvent?.Invoke();
                        break;
                    case 10:
                        UserDisconnectEvent?.Invoke();
                        break;
                    default:
                        Console.WriteLine("Reading packets...");
                        break;
                }
            }
        });
    }

    public void SendMessageToServer(string message)
    {
        PacketBuilder messagePacket = new();

        messagePacket.WriteUpcode(5);
        messagePacket.WriteMessage(message);

        client.Client.Send(messagePacket.GetPacketBytes());
    }
}