using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
int port = 8888;

IPEndPoint ipEndPoint = new(ipAddress, port);
Socket listener = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

try
{
    listener.Bind(ipEndPoint);
    listener.Listen(10);

    WriteLine("Server started...");

    while (true)
    {
        WriteLine("\nWaiting for client...");

        Socket handler = listener.Accept();
        string clientIP = ((IPEndPoint)handler.RemoteEndPoint).Address.ToString();
        WriteLine($"Client connected: {clientIP}");

        bool endReceived = false;
        while (!endReceived)
        {
            byte[] bytes = new byte[1024];
            int bytesReceived = handler.Receive(bytes);
            string dataFromClient = Encoding.UTF8.GetString(bytes, 0, bytesReceived);
            WriteLine($"Received from client ({clientIP}): {dataFromClient}");

            if (dataFromClient.Trim().ToLower() == "end")
            {
                endReceived = true;
                WriteLine("Client sended 'end'. Closing connection...");
                string responseMessage = "Connection closed!";
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage);
                handler.Send(responseBytes);
            }
            else
            {
                string responseMessage = "Received your message!";
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseMessage);
                handler.Send(responseBytes);
            }
        }
        handler.Shutdown(SocketShutdown.Both);
        handler.Close();
    }
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}
finally
{
    listener.Close();
}
