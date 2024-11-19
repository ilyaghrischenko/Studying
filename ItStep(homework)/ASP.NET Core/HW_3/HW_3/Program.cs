using HW_3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

Minesweeper _minesweeper = null;

app.MapGet("/", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.SendFileAsync("wwwroot/index.html");
});

app.MapPost("/api/minesweeper/start", () =>
{
    _minesweeper = new Minesweeper(5, 5);
    return Results.Ok(_minesweeper.Board);
});

app.MapPost("/api/minesweeper/reveal", (int x, int y) =>
{
    if (_minesweeper == null)
    {
        return Results.BadRequest("Гру не ініціалізовано. Спочатку почніть гру.");
    }

    if (_minesweeper.Board[x, y].IsMine)
    {
        return Results.BadRequest("Ви натиснули на міну!");
    }

    _minesweeper.Board[x, y].IsRevealed = true;
    return Results.Ok(_minesweeper.Board);
});

app.UseStaticFiles();

app.Run();