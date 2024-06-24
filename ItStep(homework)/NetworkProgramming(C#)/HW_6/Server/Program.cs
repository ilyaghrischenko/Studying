using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

IPAddress address = IPAddress.Parse("224.0.0.1");
int port = 12345;

await SendMessageAsync(address, port);

async Task SendMessageAsync(IPAddress address, int port)
{
    using (UdpClient server = new())
    {
        try
        {
            Write("Username: ");
            var username = ReadLine();
            if (string.IsNullOrEmpty(username)) throw new("Invalid username input");

            server.JoinMulticastGroup(address);
            string? message;
            while (true)
            {
                WriteLine("Enter message to broadcast(0 - exit):");
                message = ReadLine();
                if (string.IsNullOrEmpty(message)) throw new("Invalid message input");
                if (message == "0") break;
                string newMessage = $"{username}: {message}";
                byte[] data = Encoding.UTF8.GetBytes(newMessage);
                await server.SendAsync(data, new IPEndPoint(address, port));
                WriteLine("Message sended successfully.");
            }
            WriteLine("Finishing...");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}