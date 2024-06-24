using System.Text;
using System.Text.Json;
using HW_1;
using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//1, 2
/*
app.MapGet("/", async x =>
{
    //1
    // await x.Response.WriteAsync(DateTime.Now.DayOfYear.ToString());

    //2
    // await x.Response.WriteAsync(((char)new Random().Next(97, 122)).ToString());
});
*/

//3, 4
/*
List<string> restourans;
using (var file = File.OpenRead("restourans.json"))
{
    restourans = JsonSerializer.Deserialize<List<string>>(file);
}
app.MapGet("/", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.SendFileAsync("html/index.html");
});
app.MapGet("/allRestourans", async x =>
{
    if (restourans == null || restourans.Count == 0)
    {
        await x.Response.WriteAsync("<p>Restourans not found</p>");
    }
    else
    {
        StringBuilder res = new();
        restourans.ForEach(x => res.Append($"<p>{x}</p>\n"));
        res.Append("<a href=\"/\">Choose restouran</a>");
        await x.Response.WriteAsync(res.ToString());
    }
});
app.MapPost("/restoran", async x =>
{
    var form = x.Request.Form;
    var restoranName = form["restoran"];

    string res;
    if (!restourans.Contains(restoranName))
    {
        res = "<p>Invalid name</p>";
    }
    else res = $"<p>You choosed: {restoranName}</p>";
    await x.Response.WriteAsync(res);
});
*/

//5
/*
app.MapGet("/", async x =>
{
    x.Response.ContentType = "text/html";
    await x.Response.WriteAsync("<h1>HELLO</h1>");
});
app.MapGet("/parameter", async x =>
{
    var parameteres = x.Request.Query;
    var headers = x.Request.Headers;

    var choosedParameter = int.Parse(parameteres["id"]);
    StringBuilder stringBuilder = new();
    if (choosedParameter == 1)
    {
        using var file = File.OpenRead("countries.json");
        var countries = JsonSerializer.Deserialize<List<Country>>(file);
        countries.ForEach(x => stringBuilder.Append($"<p>{x}</p>\n"));
    }
    else if (choosedParameter == 2)
    {
        var file = File.ReadAllText("countries.json");
        stringBuilder.Append(file);
    }
    else
    {
        stringBuilder.Append("Invalid parameter");
    }

    await x.Response.WriteAsync(stringBuilder.ToString());
});
*/

app.Run();