using Lesson_5;
using Lesson_5.Models.Product;
using Microsoft.EntityFrameworkCore;
using static System.Console;

using (InternetStoreContext db = new())
{
    try
    {
        #region classwork
        //WriteLine("Products:");
        //db.Products
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();

        //WriteLine("Clients:");
        //db.Clients
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();

        //WriteLine("Personales:");
        //db.Personals
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();

        //WriteLine("Calls:");
        //db.Calls
        //    .Include("Consultant")
        //    .Include("Client")
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();

        //WriteLine("Purchases:");
        //db.Purchases
        //    .Include("Product")
        //    .Include("Customer")
        //    .Include("Consultant")
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();

        //WriteLine("Supplies:");
        //db.Supplies
        //    .Include("Provider")
        //    .Include("Product")
        //    .Include("Manager")
        //    .ToList()
        //    .ForEach(WriteLine);
        //ReadKey();
        #endregion

        #region hw
        //while (true)
        //{
        //    Write("0 - Exit\n1 - Show\n2 - Add\n3 - Delete\n: ");
        //    var fChoice = ReadKey().Key;
        //    WriteLine();
        //    switch (fChoice)
        //    {
        //        case ConsoleKey.D0:
        //            WriteLine("Bye!");
        //            return;
        //        case ConsoleKey.D1:
        //            IntenetStoreHandle.ShowAllData();
        //            break;
        //        case ConsoleKey.D2:
        //            Clear();
        //            Write("0 - Exit\n1 - Product\n2 - Personal\n3 - Client\n4 - Call\n5 - Purchase\n6 - Supply\n: ");
        //            var sChoice = ReadKey().Key;
        //            WriteLine();
        //            switch (sChoice)
        //            {
        //                case ConsoleKey.D0:
        //                    WriteLine("Bye!");
        //                    return;
        //                case ConsoleKey.D1:
        //                    Write("Name: ");
        //                    var prName = ReadLine();
        //                    Write("Developer: ");
        //                    var prDeveloper = ReadLine();
        //                    Write("Price: ");
        //                    var prPrice = decimal.Parse(ReadLine());

        //                    Clear();
        //                    Write("0 - Exit\n1 - Technique\n2 - Clothe\n3 - Book\n: ");
        //                    var tChoice = ReadKey().Key;
        //                    WriteLine();
        //                    switch (tChoice)
        //                    {
        //                        case ConsoleKey.D0:
        //                            WriteLine("Bye!");
        //                            return;
        //                        case ConsoleKey.D1:
        //                            Write("Warranty: ");
        //                            var warranty = int.Parse(ReadLine());
        //                            IntenetStoreHandle.AddTechnique(prName, prDeveloper, prPrice, warranty);
        //                            break;
        //                        case ConsoleKey.D2:
        //                            Write("Material: ");
        //                            var material = ReadLine();
        //                            Write("Season: ");
        //                            var season = ReadLine();
        //                            IntenetStoreHandle.AddClothe(prName, prDeveloper, prPrice, material, season);
        //                            break;
        //                        case ConsoleKey.D3:
        //                            Write("Chapter count: ");
        //                            var chapterCount = uint.Parse(ReadLine());
        //                            Write("Pages count: ");
        //                            var pagesCount = uint.Parse(ReadLine());
        //                            IntenetStoreHandle.AddBook(prName, prDeveloper, prPrice, chapterCount, pagesCount);
        //                            break;
        //                        default:
        //                            throw new Exception("Invalid choice");
        //                    }
        //                    break;
        //                case ConsoleKey.D2:
        //                    Write("First name: ");
        //                    var perFirstName = ReadLine();
        //                    Write("Last name: ");
        //                    var perLastName = ReadLine();
        //                    Write("Age: ");
        //                    var age = uint.Parse(ReadLine());

        //                    Clear();
        //                    Write("0 - Exit\n1 - Manager\n2 - Consultant\n: ");
        //                    tChoice = ReadKey().Key;
        //                    WriteLine();
        //                    switch (tChoice)
        //                    {
        //                        case ConsoleKey.D0:
        //                            WriteLine("Bye!");
        //                            return;
        //                        case ConsoleKey.D1:
        //                            IntenetStoreHandle.AddManager(perFirstName, perLastName, age);
        //                            break;
        //                        case ConsoleKey.D2:
        //                            IntenetStoreHandle.AddConsultant(perFirstName, perLastName, age);
        //                            break;
        //                        default:
        //                            throw new Exception("Invalid choice");
        //                    }
        //                    break;
        //                case ConsoleKey.D3:
        //                    Write("Name: ");
        //                    var clName = ReadLine();
        //                    Write("Age: ");
        //                    age = uint.Parse(ReadLine());
        //                    Write("Email: ");
        //                    var email = ReadLine();
        //                    Write("Phone number: ");
        //                    var phoneNumber = ReadLine();

        //                    Clear();
        //                    Write("0 - Exit\n1 - Customer\n2 - Provider\n: ");
        //                    tChoice = ReadKey().Key;
        //                    WriteLine();
        //                    switch (tChoice)
        //                    {
        //                        case ConsoleKey.D0:
        //                            WriteLine("Bye!");
        //                            return;
        //                        case ConsoleKey.D1:
        //                            IntenetStoreHandle.AddCustomer(clName, age, email, phoneNumber);
        //                            break;
        //                        case ConsoleKey.D2:
        //                            IntenetStoreHandle.AddProvider(clName, age, email, phoneNumber);
        //                            break;
        //                        default:
        //                            throw new Exception("Invalid choice");
        //                    }
        //                    break;
        //                case ConsoleKey.D4:
        //                    Write("Consultant id: ");
        //                    var conId = int.Parse(ReadLine());
        //                    Write("Client id: ");
        //                    var clId = int.Parse(ReadLine());
        //                    Write("Call time: ");
        //                    var callTime = DateTime.Parse(ReadLine());
        //                    IntenetStoreHandle.AddCall(conId, clId, callTime);
        //                    break;
        //                case ConsoleKey.D5:
        //                    Write("Product id: ");
        //                    var prId = int.Parse(ReadLine());
        //                    Write("Customer id: ");
        //                    var cusId = int.Parse(ReadLine());
        //                    Write("Consultant id(enter to skip): ");

        //                    var input = ReadLine();
        //                    if (input == string.Empty) IntenetStoreHandle.AddPurchase(prId, cusId);
        //                    else IntenetStoreHandle.AddPurchase(prId, cusId, int.Parse(input));
        //                    break;
        //                case ConsoleKey.D6:
        //                    Write("Provider id: ");
        //                    prId = int.Parse(ReadLine());
        //                    Write("Product id: ");
        //                    var productId = int.Parse(ReadLine());
        //                    Write("Manager id: ");
        //                    var manId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.AddSupply(prId, productId, manId);
        //                    break;
        //                default:
        //                    throw new Exception("Invalid choice");
        //            }
        //            break;
        //        case ConsoleKey.D3:
        //            Clear();
        //            Write("0 - Exit\n1 - Product\n2 - Personal\n3 - Client\n4 - Call\n5 - Purchase\n6 - Supply\n: ");
        //            sChoice = ReadKey().Key;
        //            WriteLine();
        //            switch (sChoice)
        //            {
        //                case ConsoleKey.D0:
        //                    WriteLine("Bye!");
        //                    return;
        //                case ConsoleKey.D1:
        //                    Write("Product id: ");
        //                    var productId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelProduct(productId);
        //                    break;
        //                case ConsoleKey.D2:
        //                    Write("Personal id: ");
        //                    var perId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelPersonal(perId);
        //                    break;
        //                case ConsoleKey.D3:
        //                    Write("Client id: ");
        //                    var clId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelClient(clId);
        //                    break;
        //                case ConsoleKey.D4:
        //                    Write("Call id: ");
        //                    var callId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelCall(callId);
        //                    break;
        //                case ConsoleKey.D5:
        //                    Write("Purchase id: ");
        //                    var purId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelPurchase(purId);
        //                    break;
        //                case ConsoleKey.D6:
        //                    Write("Supply id: ");
        //                    var supId = int.Parse(ReadLine());
        //                    IntenetStoreHandle.DelSupply(supId);
        //                    break;
        //                default:
        //                    throw new Exception("Invalid choice");
        //            }
        //            break;
        //        default:
        //            throw new Exception("Invalid choice");
        //    }
        //    WriteLine();
        //    ReadKey();
        //    Clear();
        //}
        #endregion
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}