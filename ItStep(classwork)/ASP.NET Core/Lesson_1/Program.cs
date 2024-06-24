var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//1
//app.Map("/", async x =>
//{
//    await x.Response.WriteAsync($"{DateTime.Now}");
//});

//2
//app.Map("/2", async x =>
//{
//    await x.Response.WriteAsync($"{new Random().Next()}");
//});

//3
//Dictionary<string, string> authorCitation = new()
//{
//    {"Author1", "Citation1"},
//    {"Author2", "Citation2"},
//    {"Author3", "Citation3"}
//};
//app.Map("/", async x =>
//{
//    var randomAuthor = authorCitation
//                           .Keys
//                           .ToList()[new Random().Next(0, authorCitation.Keys.Count)];
//    await x.Response.WriteAsync($"{randomAuthor}: \"{authorCitation[randomAuthor]}\"");
//});

//4
app.Map("/", async x =>
{

});

app.Run();