using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

IPAddress address = IPAddress.Parse($"224.0.0.1");
int port = 12345;

await ReceiveMessageAsync(address, port);

async Task ReceiveMessageAsync(IPAddress address, int port)
{
    using (UdpClient receiver = new(port))
    {
        try
        {
            receiver.JoinMulticastGroup(address);
            IPEndPoint endPoint = new(IPAddress.Any, port);
            while (true)
            {
                var data = await receiver.ReceiveAsync();
                string receivedMessage = Encoding.UTF8.GetString(data.Buffer);
                WriteLine(receivedMessage);
            }
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}