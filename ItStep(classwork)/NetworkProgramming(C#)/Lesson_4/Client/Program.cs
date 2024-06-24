using System.Net.Sockets;
using System.Text;
using static System.Console;

using (TcpClient client = new())
{
    try
    {
        await client.ConnectAsync("127.0.0.1", 8888);
        WriteLine("Connected to server");

        using (var stream = client.GetStream())
        {
            while (true)
            {
                Write("Enter the component name (or type 'END' to exit): ");
                string component = ReadLine().Trim();

                if (component.ToUpper() == "END")
                {
                    byte[] endMessage = Encoding.UTF8.GetBytes("END");
                    await stream.WriteAsync(endMessage, 0, endMessage.Length);
                    break;
                }

                byte[] request = Encoding.UTF8.GetBytes(component);
                await stream.WriteAsync(request, 0, request.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                WriteLine($"Server response: {response}");
            }
        }
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}