using System.Text.Json;
using Lesson_2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//1
app.MapGet("/", async x =>
{
    x.Response.ContentType = "text/html; charset=utf-8";
    await x.Response.SendFileAsync("html/index.html");
});

app.MapGet("/registration", async x =>
{
    x.Response.ContentType = "text/html; charset=utf-8";
    await x.Response.SendFileAsync("html/registration.html");
});

app.MapGet("/files", async x =>
{
    x.Response.ContentType = "text/html; charset=utf-8";
    await x.Response.SendFileAsync("html/files.html");
});

app.MapPost("/", async x =>
{
    var form = x.Request.Form;
    if (form["login"] == string.Empty || form["password"] == string.Empty)
    {
        x.Response.Redirect("/");
        return;
    }

    User user = new(form["login"], form["password"]);
    using (var stream = File.OpenRead("users.json"))
    {
        var users = JsonSerializer.Deserialize<List<User>>(stream) ?? new();
        if (users.Any(x => x.Login == user.Login && x.Password == user.Password))
        {
            x.Response.Redirect("/files");
            return;
        }
        x.Response.Redirect("/");
    }
});

app.MapPost("/registration", async x =>
{
    var form = x.Request.Form;
    if (form["login"] == string.Empty || form["password"] == string.Empty || form["confrimPassword"] == string.Empty)
    {
        x.Response.Redirect("/registration");
        return;
    }

    if (form["confirmPassword"] != form["password"]) x.Response.Redirect("/registration");

    User user = new(form["login"], form["password"]);
    using (var stream = File.OpenRead("users.json"))
    {
        var users = JsonSerializer.Deserialize<List<User>>(stream) ?? new();
        if (users.Count != 0 && users.Contains(user))
        {
            x.Response.Redirect("/");
            return;
        }

        users.Add(user);
        await File.WriteAllTextAsync("users.json", JsonSerializer.Serialize(users));
        x.Response.Redirect("/");
    }
});

app.Run();