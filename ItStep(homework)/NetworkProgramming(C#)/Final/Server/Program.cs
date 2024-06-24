using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

TcpListener? server = null;
TcpClient? client = null;

try
{
    int port = 8888;
    IPAddress localAddr = IPAddress.Parse("127.0.0.1");

    server = new TcpListener(localAddr, port);
    server.Start();

    WriteLine("Waiting for a connection... ");
    while (true)
    {
        client = server.AcceptTcpClient();
        WriteLine("Connected!");

        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
        string received = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        WriteLine($"Received: {received}");

        string response = await HandleRequest(received);

        byte[] responseData = Encoding.UTF8.GetBytes(response);
        await stream.WriteAsync(responseData, 0, responseData.Length);
    }
}
catch (Exception ex)
{
    WriteLine($"Error: {ex.Message}");
}
finally
{
    server?.Stop();
}

WriteLine("\nServer stopped. Press any key to exit...");
ReadKey();

async Task<string> HandleRequest(string request)
{
    if (request.Trim().ToLower() == "bye")
    {
        client.Close();
        return "Goodbye!";
    }

    var tokens = request.Split(" ,./\\?!'\";:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
    tokens.ForEach(x => x.ToLower());

    var files = Directory.GetFiles("texts").ToList();
    string result = "";
    foreach (var item in files)
    {
        string text = await File.ReadAllTextAsync(item);
        var textTokens = text.Split(" ,./\\?!'\";:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        textTokens.ForEach(x => x.ToLower());
        var changedText = string.Join(' ', textTokens);
        if (tokens.All(changedText.Contains)) result += text + " <EndText>";
    }
    return (result != string.Empty) ? result : "418 I’m a teapot";
}
