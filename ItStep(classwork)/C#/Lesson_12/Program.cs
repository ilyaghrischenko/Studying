using static System.Console;

namespace Lesson_12
{
    internal class Program
    {
        private static void ChangeLoginPass(ref Dictionary<string, string> dict, string login, string newPass)
        {
            if (!dict.ContainsKey(login)) throw new Exception();
            dict[login] = newPass;
        }
        
        static void Main(string[] args)
        {
            try
            {
                //task 1
                /*
                Employee employee1 = new("p", "p", 1.1, "ema"); 
                Employee employee2 = new("pi", "po", 2.2, "emai"); 
                Employee employee3 = new("pib", "pos", 3.3, "email"); 
                Employee employee4 = new("pibb", "poss", 4.4, "emaill");

                List<Employee> list = new() { employee1, employee2, employee3, employee4 };

                EmployeeAccounting employees = new(list);
                employees.Show();

                WriteLine();
                ReadKey();

                employees.AddEmployee(new Employee());
                employees.AddEmployee(new Employee("PIB", "POS", 6.6, "EMAIL"));
                employees.Show();
                */

                //task 2
                /*
                Dictionary<string, string> loginPass = new();
                loginPass.Add("tugkdkd", "eirir34983");
                loginPass.Add("jgfklh94", "egdgj824");
                loginPass.Add("123fuu", "495kgkg");

                int choice = -1;
                string login, password;
                while (choice != 0)
                {
                    Write("0 - Exit\n1 - Add\n2 - Del login\n3 - Change login and password\n4 - Find by login\n5 - Show dict\n: ");
                    if (!int.TryParse(ReadLine(), out choice))
                    {
                        throw new Exception();
                    }

                    switch (choice)
                    {
                        case 0:
                            WriteLine("Exit");
                            break;
                        case 1:
                            Write("Login: ");
                            login = ReadLine();

                            Write("Password: ");
                            password = ReadLine();

                            if (login == "" || password == "") throw new Exception();

                            if (!loginPass.ContainsKey(login))
                            {
                                loginPass.Add(login, password);
                            }
                            break;
                        case 2:
                            Write("Login: ");
                            login = ReadLine();
                            if (login == "") throw new Exception();

                            if (loginPass.ContainsKey(login)) loginPass.Remove(login);
                            break;
                        case 3:
                            Write("Old login: ");
                            login = ReadLine();
                            
                            Write("New pass: ");
                            string newPass = ReadLine();

                            ChangeLoginPass(ref loginPass, login, newPass);
                            break;
                        case 4:
                            Write("Login: ");
                            login = ReadLine();

                            if (!loginPass.ContainsKey(login)) throw new Exception();
                            WriteLine($"Finded login: {loginPass[login]}");
                            break;
                        case 5:
                            WriteLine("Dict:");
                            foreach (var pair in loginPass)
                            {
                                WriteLine($"{pair.Key} : {pair.Value}");
                            }
                            break;
                    }
                    WriteLine();
                    ReadKey();
                    Clear();
                }
                */

                //task 3
                Queue<string> strings = new Queue<string>();


                WriteLine();
                ReadKey();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
