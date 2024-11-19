using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors.Infrastructure;
using DB;

var builder = WebApplication.CreateBuilder(args);

// Додавання контексту бази даних
builder.Services.AddDbContext<BookStoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookStore")));

// Налаштування CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAny", builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });

    options.AddPolicy("Restricted",
        builder => { builder.WithOrigins("http://localhost:37777").AllowAnyMethod().AllowAnyHeader(); });

    options.AddPolicy("DatabaseOnly",
        builder => { builder.WithOrigins("http://localhost:3500").AllowAnyMethod().AllowAnyHeader(); });
});

// Додавання служб контролерів
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}

// Другие middleware
app.UseRouting();
app.UseAuthorization();

// Налаштування middleware
app.UseRouting();
app.UseCors("AllowAny"); // Для перегляду всіх книг і авторів
app.UseAuthorization();

app.MapControllers(); // Реєстрація контролерів

app.Run();