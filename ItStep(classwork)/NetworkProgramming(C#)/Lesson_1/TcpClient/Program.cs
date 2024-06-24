using static System.Console;
using System.Net;
using System.Net.Sockets;
using System.Text;

//task 1,2
IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
int port = 8888;

IPEndPoint ipEndPoint = new(ipAddress, port);
Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

try
{
    socket.Connect(ipEndPoint);

    Write("Enter name: ");
    string? name = ReadLine();
    socket.Send(Encoding.UTF8.GetBytes(name));

    byte[] responseBytes = new byte[256];
    int count = socket.Receive(responseBytes);
    string serverData = Encoding.UTF8.GetString(responseBytes, 0, count);
    WriteLine($"server: {serverData}");

    while (true)
    {
        Write("Enter your message: ");
        string? message = ReadLine();

        socket.Send(Encoding.UTF8.GetBytes(message));

        byte[] bytesReceived = new byte[256];
        int bytesReceivedCount = socket.Receive(bytesReceived);
        string dataFromServer = Encoding.UTF8.GetString(bytesReceived, 0, bytesReceivedCount);
        WriteLine($"server: {dataFromServer}");
        if (message == "end") break;
    }
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}
finally
{
    socket.Shutdown(SocketShutdown.Both);
    socket.Close();
}