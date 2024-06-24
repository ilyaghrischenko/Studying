using HW_2.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

TickTackToe tickTackToe = new();

app.MapGet("/", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.SendFileAsync("html/index.html");
});
app.MapGet("/guessNumber", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.SendFileAsync("html/guess/guessNumber.html");
});
app.MapGet("/tickTackToe", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.SendFileAsync("html/ticktacktoe/tickTackToe.html");
});
app.MapPost("/tryGuess", async x =>
{
    var form = x.Request.Form;
    x.Response.ContentType = "text/html";
    if (!int.TryParse(form["userNumber"], out var number))
    {
        await x.Response.SendFileAsync("html/guess/guessNumber.html");
    }

    if (!new GuessNumber().TryGuess(number))
    {
        await x.Response.SendFileAsync("html/guess/invalidNumber.html");
    }
    else await x.Response.SendFileAsync("html/guess/win.html");
});
app.MapPost("/userChoice", async x =>
{
    var form = x.Request.Form;
    var userInput = int.Parse(form["value"]);
    tickTackToe.ChangeValue(userInput);
    await x.Response.SendFileAsync("html/ticktacktoe/tickTackToe.html");
});

app.Run();