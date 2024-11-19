using System;
using System.Net.Sockets;
using System.Text;

class RecipeTcpClient
{
    public static void Main(string[] args)
    {
        var client = new TcpClient("127.0.0.1", 8000);
        var stream = client.GetStream();

        var message = "tomato, cheese";
        var data = Encoding.UTF8.GetBytes(message);

        // Відправка запиту
        stream.Write(data, 0, data.Length);

        // Отримання відповіді
        var buffer = new byte[1024];
        var byteCount = stream.Read(buffer, 0, buffer.Length);
        var response = Encoding.UTF8.GetString(buffer, 0, byteCount);

        Console.WriteLine($"Received: {response}");

        stream.Close();
        client.Close();
    }
}