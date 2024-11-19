using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class RecipeTcpServer
{
    private TcpListener _server;
    private bool _isRunning;

    public RecipeTcpServer(string ipAddress, int port)
    {
        _server = new TcpListener(IPAddress.Parse(ipAddress), port);
        _server.Start();
        _isRunning = true;
        Console.WriteLine("Server is running...");
        Listen();
    }

    public void Listen()
    {
        while (_isRunning)
        {
            var client = _server.AcceptTcpClient();
            var clientThread = new Thread(HandleClient);
            clientThread.Start(client);
        }
    }

    public void HandleClient(object clientObj)
    {
        var client = (TcpClient)clientObj;
        var stream = client.GetStream();
        var buffer = new byte[1024];
        var byteCount = stream.Read(buffer, 0, buffer.Length);
        var data = Encoding.UTF8.GetString(buffer, 0, byteCount);

        Console.WriteLine($"Received data: {data}");

        // Обробка запиту клієнта
        var response = GetRecipesByIngredients(data);
        var responseData = Encoding.UTF8.GetBytes(response);

        // Відправка відповіді клієнту
        stream.Write(responseData, 0, responseData.Length);
        stream.Close();
        client.Close();
    }

    public string GetRecipesByIngredients(string ingredients)
    {
        // Тут можна зробити пошук рецептів по інгредієнтах
        return $"Here are some recipes for {ingredients}";
    }
}
