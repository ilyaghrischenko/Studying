using System.Net;
using static System.Console;

namespace Lesson_15
{
    internal class Program
    {
        //task 5
        /*
        enum SortOrder
        {
            Ascending,
            Descending
        }
        static int SumOfDigits(int num)
        {
            return num.ToString().Sum(x => x);
        }
        static int CompareBySumOfDigits(int x, int y, SortOrder sortOrder)
        {
            int sumX = SumOfDigits(x);
            int sumY = SumOfDigits(y);

            if (sortOrder == SortOrder.Ascending) return sumX.CompareTo(sumY);
            return sumY.CompareTo(sumX);
        }
        static void CustomSort(List<int> arr, SortOrder sortOrder = SortOrder.Ascending)
        {
            arr.Sort((x, y) => CompareBySumOfDigits(x, y, sortOrder));
        }
        */

        static void Main(string[] args)
        {
            try
            {
                //task 1
                /*
                List<int> arrayInt = new();
                Random random = new();
                for (int i = 0; i < random.Next(3, 20); ++i)
                {
                    arrayInt.Add(random.Next(random.Next(-100, 0), random.Next(1, 100)));
                }

                //1
                WriteLine("1.");
                arrayInt
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //2
                WriteLine("2.");
                arrayInt
                    .Where(x => x % 2 == 0)
                    .ToList()
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //3
                WriteLine("3.");
                var nepList = arrayInt
                    .Where(x => x % 2 != 0)
                    .ToList();
                nepList
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //4
                WriteLine("4.");
                var rangeList = arrayInt
                    .Where(x => x > 10 && x < 50)
                    .ToList();
                rangeList
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //5
                WriteLine("5.");
                var krat5List = arrayInt
                    .Where(x => x % 7 == 0)
                    .Order()
                    .ToList();
                krat5List
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //6
                WriteLine("6.");
                var krat8List = arrayInt
                    .Where(x => x % 8 == 0)
                    .OrderDescending()
                    .ToList();
                krat8List
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");
                */

                //task 2
                /*
                List<string> cities = new List<string>
                {
                    "Amsterdam",
                    "Athens",
                    "Ottawa",
                    "Oslo",
                    "Dubai",
                    "Kyiv",
                    "Toronto",
                    "London",
                    "New York"
                };

                //1
                WriteLine("1.");
                cities
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //2
                WriteLine("2.");
                var newCities = cities
                    .Where(x => x.Length == 4)
                    .ToList();
                newCities
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //3
                WriteLine("3.");
                var AList = cities
                    .Where(x => x.StartsWith('A'))
                    .ToList();
                AList
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //4
                WriteLine("4.");
                var listM = cities
                    .Where(x => x.EndsWith('m'))
                    .ToList();
                listM
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                //5
                WriteLine("5.");
                var NlistK = cities
                    .Where(x => x.StartsWith('N') && x.EndsWith('k'))
                    .ToList();
                NlistK
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");
                */

                //task 3
                /*
                List<Student> students = new List<Student>
                {
                    new Student(),
                    new Student(){ Name = "Maksym", SurName = "Lov", Age = 18, InstitutionName = "KrNU" },
                    new Student(){ Name = "Maksym", SurName = "Lov", Age = 19, InstitutionName = "KrNU" },
                    new Student(){ Name = "Maksym", SurName = "Lov", Age = 20, InstitutionName = "KrNU" },
                    new Student(){ Name = "Roma", SurName = "Mosh", Age = 18, InstitutionName = "KrNU" },
                    new Student(){ Name = "Roma", SurName = "Mosh", Age = 29, InstitutionName = "KrNU" },
                    new Student(){ Name = "Aleksey", SurName = "Mosh", Age = 20, InstitutionName = "KrNU" },
                    new Student(){ Name = "Roma", SurName = "Mosh", Age = 21, InstitutionName = "KrNU" },
                    new Student(){ Name = "Maksym", SurName = "Broll", Age = 19, InstitutionName = "Oxford" },
                    new Student(){ Name = "Aleksey", SurName = "Brol", Age = 20, InstitutionName = "Oxford" },
                    new Student(){ Name = "Dima", SurName = "Brll", Age = 21, InstitutionName = "Oxford" },
                    new Student(){ Name = "Dima", SurName = "Butnyk", Age = 45, InstitutionName = "KrNU" }
                };

                //1
                WriteLine("1.");
                students
                    .ForEach(WriteLine);
                WriteLine();

                //2
                WriteLine("2.");
                var broList = students
                    .Where(x => x.SurName.StartsWith("Bro"))
                    .ToList();
                broList
                    .ForEach(WriteLine);
                WriteLine();

                //3
                WriteLine("3.");
                var oldStudents = students
                    .Where(x => x.Age > 19)
                    .ToList();
                oldStudents
                    .ForEach(WriteLine);
                WriteLine();

                //4
                WriteLine("4.");
                var rangeStudents = students
                    .Where(x => x.Age > 20 && x.Age < 23)
                    .ToList();
                rangeStudents
                    .ForEach(WriteLine);
                WriteLine();

                //5
                WriteLine("5.");
                var oxfordList = students
                    .Where(x => x.InstitutionName == "Oxford" && x.Age > 18)
                    .OrderBy(x => x.Age)
                    .ToList();
                oxfordList
                    .ForEach(WriteLine);
                WriteLine();
                */

                //task 4
                /*
                List<Firm> firms = new List<Firm>
                {
                    new Firm{Name="Food", BusinessProfile="IT",DirectorPib="White",WorkerKilk=90,Address="Address"},
                    new Firm{Name="White", FoundingDate=new DateTime(2020,4,12), BusinessProfile="Marketing",DirectorPib="Black",WorkerKilk=150,Address="Address"},
                    new Firm{Name="Name", BusinessProfile="Marketing",DirectorPib="DirPib",WorkerKilk=80,Address="London"},
                    new Firm{Name="Food", FoundingDate=new DateTime(2019,6,28), BusinessProfile="IT",DirectorPib="White",WorkerKilk=260,Address="London"},
                    new Firm{Name="White", FoundingDate=new DateTime(2023,10,22), BusinessProfile="Marketing",DirectorPib="Black",WorkerKilk=200,Address="Address"},
                    new Firm{Name="Food", BusinessProfile="IT",DirectorPib="DirPib",WorkerKilk=1000,Address="Address"},
                    new Firm{Name="White", BusinessProfile="Marketing",DirectorPib="White",WorkerKilk=1000,Address="London"},
                    new Firm{Name="Food", FoundingDate=new DateTime(2023,10,22), BusinessProfile="Marketing",DirectorPib="DirPib",WorkerKilk=200,Address="Address"},
                    new Firm{Name="White", FoundingDate=new DateTime(2023,10,22), BusinessProfile="Marketing",DirectorPib="Black",WorkerKilk=200,Address="Address"}
                };

                //1
                WriteLine("1.");
                firms
                    .ForEach(WriteLine);
                WriteLine("\n");

                //2
                WriteLine("2.");
                var foodList = firms
                    .Where(x => x.Name.Contains("Food"))
                    .ToList();
                foodList
                    .ForEach(WriteLine);
                WriteLine("\n");
                
                //3
                WriteLine("3.");
                firms
                     .Where(x => x.BusinessProfile == "Marketing")
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //4
                WriteLine("4.");
                firms
                     .Where(x => x.BusinessProfile == "Marketing" || x.BusinessProfile == "IT")
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //5
                WriteLine("5.");
                firms
                     .Where(x => x.WorkerKilk > 100)
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //6
                WriteLine("6.");
                firms
                     .Where(x => x.WorkerKilk >= 100 && x.WorkerKilk <= 300)
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //7
                WriteLine("7.");
                firms
                     .Where(x => x.Address == "London")
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //8
                WriteLine("8.");
                firms
                     .Where(x => x.DirectorPib.Contains("White"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //9
                WriteLine("9.");
                firms
                     .Where(x => x.FoundingDate.Year <= 2022)
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //10
                WriteLine("10.");
                firms
                     .Where(x => (DateTime.Today - x.FoundingDate).Days == 123)
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //11
                WriteLine("11.");
                firms
                     .Where(x => x.DirectorPib.Contains("Black") && x.Name.Contains("White"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");
                */

                //task 5
                /*
                List<int> ints = new() { 10, 65, 99, 34, 21 };
                CustomSort(ints, SortOrder.Descending);

                WriteLine("Sorted list:");
                ints
                    .ForEach(WriteLine);
                */

                //task 6
                /*
                List<int> list1 = new();
                List<int> list2 = new();
                Random rnd = new();
                for (int i = 0; i < 10; ++i)
                {
                    list1.Add(rnd.Next(-100, 100));
                    list2.Add(rnd.Next(-100, 100));
                }

                WriteLine("1 list:");
                list1
                    .ForEach(x => Write($"{x}  "));
                WriteLine("\n2 list:");
                list2
                    .ForEach(x => Write($"{x}  "));

                //1
                WriteLine("\n\n1.");
                list1
                     .Except(list2)
                     .ToList()
                     .ForEach(x => Write($"{x}  "));

                //2
                WriteLine("\n2.");
                list1
                     .Intersect(list2)
                     .ToList()
                     .ForEach(x => Write($"{x}  "));

                //3
                WriteLine("\n3.");
                list1
                     .Intersect(list2)
                     .Distinct()
                     .ToList()
                     .ForEach(x => Write($"{x}  "));

                //4
                WriteLine("\n4.");
                list1
                     .Distinct()
                     .ToList()
                     .ForEach(x => Write($"{x}  "));
                */

                //task 7
                /*
                List<Firm> firms = new List<Firm>
                {
                    new Firm
                    {
                        Name = "Food",
                        BusinessProfile = "IT",
                        DirectorPib = "White",
                        WorkerKilk = 90,
                        Address = "Address",
                        Workers = new List<Worker>
                        {
                            new Worker("Lionel Smith", "Developer", "233456789", "john@example.com", 3000),
                            new Worker("Alice Johnson", "QA Engineer", "987654321", "alice@example.com", 2800)
                        }
                    },
                    new Firm
                    {
                        Name = "White",
                        FoundingDate = new DateTime(2020, 4, 12),
                        BusinessProfile = "Marketing",
                        DirectorPib = "Black",
                        WorkerKilk = 150,
                        Address = "Address",
                        Workers = new List<Worker>
                        {
                            new Worker("Bob Brown", "Marketing Manager", "111222333", "bob@example.com", 3500),
                            new Worker("Lionel Wilson", "Graphic Designer", "444555666", "diily@example.com", 3200)
                        }
                    },
                    new Firm
                    {
                        Name = "Name",
                        BusinessProfile = "Marketing",
                        DirectorPib = "DirPib",
                        WorkerKilk = 80,
                        Address = "London",
                        Workers = new List<Worker>
                        {
                            new Worker("David Miller", "Sales Manager", "777888999", "divid@example.com", 4000),
                            new Worker("Emma Clark", "Marketing Analyst", "233444555", "emma@example.com", 3800)
                        }
                    }
                };

                //1
                WriteLine("1.");
                firms
                     .Where(x => x.Name == "Food")
                     .ToList()
                     .ForEach(x => x.Workers.ForEach(WriteLine));
                WriteLine("\n");

                //2
                WriteLine("2.");
                firms
                     .Where(x => x.BusinessProfile == "Marketing")
                     .SelectMany(x => x.Workers)
                     .Where(x => x.Salary > 3000)
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //3
                WriteLine("3.");
                firms
                     .SelectMany(x => x.Workers)
                     .Where(x => x.Position.Contains("Manager"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //4
                WriteLine("4.");
                firms
                     .SelectMany(x => x.Workers)
                     .Where(x => x.PhoneNumber.StartsWith("23"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //5
                WriteLine("5.");
                firms
                     .SelectMany(x => x.Workers)
                     .Where(x => x.Email.StartsWith("di"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");

                //6
                WriteLine("6.");
                firms
                     .SelectMany(x => x.Workers)
                     .Where(x => x.Pib.Contains("Loinel"))
                     .ToList()
                     .ForEach(WriteLine);
                WriteLine("\n");
                */
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            WriteLine();
            ReadKey();
        }
    }
}