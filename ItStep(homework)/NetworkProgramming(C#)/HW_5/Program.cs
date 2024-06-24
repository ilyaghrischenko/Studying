using HW_5;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Console;

IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

Write("Enter local port: ");
int localPort = int.Parse(ReadLine());
Write("Enter remote port: ");
int remotePort = int.Parse(ReadLine());
Write("Enter name: ");
var name = ReadLine();

using UdpClient sender = new();
using UdpClient receiver = new(localPort);
bool canSend = true;

try
{
    Task.Run(ReceiveMessageAsync);
    await SendMessageAsync();
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

async Task SendMessageAsync()
{
    WriteLine("Enter figure and press ENTER");
    if (!Enum.TryParse(typeof(FigureEnum), ReadLine(), out var figure)) return;

    var message = $"{name}: {figure}";
    byte[] data = Encoding.Unicode.GetBytes(message);
    await sender.SendAsync(data, data.Length, new IPEndPoint(ipAddress, remotePort));

    await Task.Delay(100);
    while (canSend)
    {
        await Task.Delay(100);
    }
}
async Task ReceiveMessageAsync()
{
    while (true)
    {
        var result = await receiver.ReceiveAsync();
        var message = Encoding.Unicode.GetString(result.Buffer);
        var enemy = (FigureEnum)Enum.Parse(typeof(FigureEnum), message.Split(':')[1].Trim());

        WriteLine("Enter figure and press ENTER");
        if (!Enum.TryParse(typeof(FigureEnum), ReadLine(), out var myFigure)) return;

        await ClashAsync((FigureEnum)myFigure, enemy);
        canSend = false;
    }
}

async Task ClashAsync(FigureEnum first, FigureEnum second)
{
    if (second == first) WriteLine("Draw");
    else if (first == FigureEnum.Stone)
    {
        if (second == FigureEnum.Scissors) WriteLine($"{first} wins");
        else if (second == FigureEnum.Paper) WriteLine($"{second} wins");
    }
    else if (first == FigureEnum.Scissors)
    {
        if (second == FigureEnum.Stone) WriteLine($"{second} wins");
        else if (second == FigureEnum.Paper) WriteLine($"{first} wins");
    }
    else if (first == FigureEnum.Paper)
    {
        if (second == FigureEnum.Stone) WriteLine($"{first} wins");
        else if (second == FigureEnum.Scissors) WriteLine($"{second} wins");
    }
}