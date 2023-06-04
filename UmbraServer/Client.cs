using System.Net.Sockets;
using UmbraServer.Net.IO;

namespace UmbraServer;

internal sealed class Client
{
    private readonly PacketReader packetReader;

    public string Username { get; set; }
    public Guid UID { get; set; }
    public TcpClient ClientSocket { get; set; }
    public Client(TcpClient socket)
    {
        UID = Guid.NewGuid();
        ClientSocket = socket;
        packetReader = new(ClientSocket.GetStream());

        var opcode = packetReader.ReadByte();
        Username = packetReader.ReadMessage();

        Notification(Username, "has connected");
        Task.Run(() => Process());
    }

    private void Process()
    {
        while (true)
        {
            try
            {
                var opcode = packetReader.ReadByte();

                switch (opcode)
                {
                    case 5:
                        var message = packetReader.ReadMessage();
                        Notification(": ", message);
                        Program.BroadcastMessage(message);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Notification(UID.ToString(), "has disconnected");
                Program.BroadcastDisconnect(UID.ToString());
                ClientSocket.Close();
                break;
            }
        }
    }

    public static void Notification(string arg0, string arg1, ConsoleColor highlightColor = ConsoleColor.Yellow)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"[{DateTime.Now}] ");

        Console.ForegroundColor = highlightColor;
        Console.Write(arg0);

        Console.ResetColor();
        Console.Write($" {arg1}\n");
    }
}