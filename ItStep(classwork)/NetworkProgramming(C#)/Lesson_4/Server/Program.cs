using Server;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

List<PCComponent> components = new()
{
    new PCComponent(ComponentType.CPU, "Intel Core i9-11900K", "Intel", 18000),
    new PCComponent(ComponentType.CPU, "AMD Ryzen 5 5600X", "AMD", 10000),
    new PCComponent(ComponentType.GPU, "Nvidia GeForce RTX 3080", "Nvidia", 50000),
    new PCComponent(ComponentType.GPU, "AMD Radeon RX 6700 XT", "AMD", 30000),
    new PCComponent(ComponentType.RAM, "Corsair Vengeance LPX", "Corsair", 3000),
    new PCComponent(ComponentType.RAM, "Adata XPG", "Adata", 3000),
    new PCComponent(ComponentType.HDD, "Seagate Barracuda 1TB", "Seagate Technology", 2500),
    new PCComponent(ComponentType.HDD, "Seagate BarraCuda 2TB", "Seagate Technology", 2700)
};

using (TcpListener server = new(IPAddress.Parse("127.0.0.1"), 8888))
{
    try
    {
        server.Start();
        WriteLine("Server started");

        while (true)
        {
            TcpClient client = await server.AcceptTcpClientAsync();
            WriteLine($"Client connected: {client.Client.RemoteEndPoint}");

            Task.Run(async () => await HandleClientAsync(client));
        }
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}

async Task HandleClientAsync(TcpClient client)
{
    try
    {
        using (var stream = client.GetStream())
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                if (request.ToUpper() == "END")
                {
                    WriteLine("Client requested to end the session.");
                    break;
                }

                string response = ProcessRequest(request);
                byte[] data = Encoding.UTF8.GetBytes(response);
                await stream.WriteAsync(data, 0, data.Length);
            }
            
        }
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}
string ProcessRequest(string request)
{
    if (Enum.TryParse(typeof(ComponentType), request, out object? result))
    {
        var type = (ComponentType)result;
        string text = "\n";
        components
            .Where(x => x.Type == type)
            .ToList()
            .ForEach(x => text += $"{x}\n");
        return text;
    }

    var founded = components.FirstOrDefault(x => x.Name == request);
    if (founded == null)
    {
        return "Component is not found";
    }

    return $"{request}: {founded.Price} grn";
}
