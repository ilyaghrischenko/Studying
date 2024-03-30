using System.Text.Json;
using static System.Console;

namespace Quiz
{
    public class AuthorisationRegistration
    {
        private const string _path = "registeredUsers.json";
        private static List<User>? _registeredUsers = GetRegisteredUsers();

        private static List<User>? GetRegisteredUsers()
        {
            if (!File.Exists(_path)) return new();

            string jsonContent = File.ReadAllText(_path);
            if (jsonContent == string.Empty) return new();

            List<User>? _registeredUsers = JsonSerializer.Deserialize<List<User>>(jsonContent);
            return _registeredUsers;
        }
        private static void Save()
        {
            string jsonString = JsonSerializer.Serialize(_registeredUsers);
            File.WriteAllText(_path, jsonString);
        }

        public static void Authorisation(User user)
        {
            WriteLine("Authorisation:");

            Write("Name: ");
            string name = ReadLine() ?? "empty";
            Write("Email: ");
            string email = ReadLine() ?? "empty";

            if (_registeredUsers.Count == 0)
            {
                Registration(user);
                return;
            }

            foreach (var item in _registeredUsers)
            {
                if (item.Name == name && item.Email == email) WriteLine("You're logged in");
                return;
            }

            Registration(user);
        }
        public static void Registration(User user)
        {
            foreach (var item in _registeredUsers)
            {
                if (item.Equals(user)) throw new ArgumentException("Error: This user already exists");
            }

            WriteLine("You've registered");
            _registeredUsers.Add(user);
            Save();
        }
    }
}
