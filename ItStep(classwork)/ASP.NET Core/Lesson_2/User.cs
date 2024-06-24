using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Lesson_2;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    
    public User() { }
    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }

    public override string ToString()
    {
        return $"Login: {Login}, Password: {Password}";
    }
}