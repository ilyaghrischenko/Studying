using DB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PublicPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });

    options.AddPolicy("RestrictedPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:37777")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });

    options.AddPolicy("DeletePolicy", policy =>
    {
        policy.WithOrigins("http://localhost:3500")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("PublicPolicy");

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();