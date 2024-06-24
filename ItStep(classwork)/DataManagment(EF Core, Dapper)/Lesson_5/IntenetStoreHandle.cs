using Azure;
using Lesson_5.Models.Client;
using Lesson_5.Models.Data;
using Lesson_5.Models.Personal;
using Lesson_5.Models.Product;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;
using static System.Console;

namespace Lesson_5
{
    public static class IntenetStoreHandle
    {
        public static void ShowAllData()
        {
            using (InternetStoreContext db = new())
            {
                WriteLine("Products:");
                db.Products
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();

                WriteLine("Clients:");
                db.Clients
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();

                WriteLine("Personales:");
                db.Personals
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();

                WriteLine("Calls:");
                db.Calls
                    .Include("Consultant")
                    .Include("Client")
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();

                WriteLine("Purchases:");
                db.Purchases
                    .Include("Product")
                    .Include("Customer")
                    .Include("Consultant")
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();

                WriteLine("Supplies:");
                db.Supplies
                    .Include("Provider")
                    .Include("Product")
                    .Include("Manager")
                    .ToList()
                    .ForEach(WriteLine);
                ReadKey();
            }
        }

        public static void AddTechnique(string name, string developer, decimal price, int warranty)
        {
            using (InternetStoreContext db = new())
            {
                Technique technique = new(name, developer, price, warranty);
                if (db.Techniques.SingleOrDefault(x => x.Name == technique.Name && x.Developer == technique.Developer && x.Price == technique.Price && x.Warranty == technique.Warranty) != null) throw new Exception("This technique already exist");
                db.Techniques.Add(technique);
                db.SaveChanges();
            }
        }
        public static void AddClothe(string name, string developer, decimal price, string material, string season)
        {
            using (InternetStoreContext db = new())
            {
                Clothe clothe = new(name, developer, price, material, season);
                if (db.Clothes.SingleOrDefault(x => x.Name == clothe.Name && x.Developer == clothe.Developer && x.Price == clothe.Price && x.Material == clothe.Material && x.Season == clothe.Season) != null) throw new Exception("This clothe already exist");
                db.Clothes.Add(clothe);
                db.SaveChanges();
            }
        }
        public static void AddBook(string name, string developer, decimal price, uint chapterCount, uint pagesCount)
        {
            using (InternetStoreContext db = new())
            {
                Book book = new(name, developer, price, chapterCount, pagesCount);
                if (db.Books.SingleOrDefault(x => x.Name == book.Name && x.Developer == book.Developer && x.Price == book.Price && x.ChapterCount == book.ChapterCount && x.PagesCount == book.PagesCount) != null) throw new Exception("This book already exist");
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
        public static void AddManager(string firstName, string lastName, uint age)
        {
            using (InternetStoreContext db = new())
            {
                Manager manager = new(firstName, lastName, age);
                if (db.Managers.SingleOrDefault(x => x.FirstName == manager.FirstName && x.LastName == manager.LastName && x.Age == manager.Age) != null) throw new Exception("This manager already exist");
                db.Managers.Add(manager);
                db.SaveChanges();
            }
        }
        public static void AddConsultant(string firstName, string lastName, uint age)
        {
            using (InternetStoreContext db = new())
            {
                Consultant consultant = new(firstName, lastName, age);
                if (db.Consultants.SingleOrDefault(x => x.FirstName == consultant.FirstName && x.LastName == consultant.LastName && x.Age == consultant.Age) != null) throw new Exception("This consultant already exist");
                db.Consultants.Add(consultant);
                db.SaveChanges();
            }
        }
        public static void AddSupply(int providerId, int productId, int managerId)
        {
            using (InternetStoreContext db = new())
            {
                var provider = db.Providers.SingleOrDefault(x => x.Id == providerId) ?? throw new Exception("Provider with this id does not exist");
                var product = db.Products.SingleOrDefault(x => x.Id == productId) ?? throw new Exception("Product with this id does not exist");
                var manager = db.Managers.SingleOrDefault(x => x.Id == managerId) ?? throw new Exception("Manager with this id does not exist");

                Supply supply = new() { Provider = provider, Product = product, Manager = manager };
                if (db.Supplies.SingleOrDefault(x => x.Provider == supply.Provider && x.Product == supply.Product && x.Manager == supply.Manager) != null) throw new Exception("This supply already exist");
                db.Supplies.Add(supply);
                db.SaveChanges();
            }
        }
        public static void AddPurchase(int productId, int customerId, int? consultantId = null)
        {
            using (InternetStoreContext db = new())
            {
                var product = db.Products.SingleOrDefault(x => x.Id == productId) ?? throw new Exception("Product with this id does not exist");
                var customer = db.Customers.SingleOrDefault(x => x.Id == customerId) ?? throw new Exception("Customer with this id does not exist");
                var consultant = (consultantId != null) ? db.Consultants.SingleOrDefault(x => x.Id == consultantId) ?? throw new Exception("Consultant with this id does not exist") : null;

                Purchase purchase = new() { Product = product, Customer = customer, Consultant = consultant };
                if (db.Purchases.SingleOrDefault(x => x.Product == purchase.Product && x.Customer == purchase.Customer && x.Consultant == purchase.Consultant) != null) throw new Exception("This purchase already exist");
                db.Purchases.Add(purchase);
                db.SaveChanges();
            }
        }
        public static void AddCall(int counsultantId, int clientId, DateTime callTime)
        {
            using (InternetStoreContext db = new())
            {
                var consultant = db.Consultants.SingleOrDefault(x => x.Id == clientId) ?? throw new Exception("Consultant with this id does not exist");
                var client = db.Clients.SingleOrDefault(x => x.Id == clientId) ?? throw new Exception("Client with this id does not exist");

                Call call = new() { Consultant = consultant, Client = client, CallTime = callTime };
                if (db.Calls.SingleOrDefault(x => x.Consultant == call.Consultant && x.Client == call.Client && x.CallTime == call.CallTime) != null) throw new Exception("This call already exist");
                db.Calls.Add(call);
                db.SaveChanges();
            }
        }
        public static void AddProvider(string name, uint age, string email, string phoneNumber)
        {
            using (InternetStoreContext db = new())
            {
                Provider provider = new() { Name = name, Age = age, Email = email, PhoneNumber = phoneNumber };
                if (db.Providers.SingleOrDefault(x => x.Name == provider.Name && x.Age == provider.Age && x.Email == provider.Email && x.PhoneNumber == provider.PhoneNumber) != null) throw new Exception("This provider already exist");
                db.Providers.Add(provider);
                db.SaveChanges();
            }
        }
        public static void AddCustomer(string name, uint age, string email, string phoneNumber)
        {
            using (InternetStoreContext db = new())
            {
                Customer customer = new() { Name = name, Age = age, Email = email, PhoneNumber = phoneNumber };
                if (db.Customers.SingleOrDefault(x => x.Name == customer.Name && x.Age == customer.Age && x.Email == customer.Email && x.PhoneNumber == customer.PhoneNumber) != null) throw new Exception("This customer already exist");
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void DelProduct(int productId)
        {
            using (InternetStoreContext db = new())
            {
                var product = db.Products.SingleOrDefault(x => x.Id == productId) ?? throw new Exception("Product with this id does not exist");
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
        public static void DelPersonal(int personId)
        {
            using (InternetStoreContext db = new())
            {
                var person = db.Personals.SingleOrDefault(x => x.Id == personId) ?? throw new Exception("Personal with this id does not exist");
                db.Personals.Remove(person);
                db.SaveChanges();
            }
        }
        public static void DelClient(int clientId)
        {
            using (InternetStoreContext db = new())
            {
                var client = db.Clients.SingleOrDefault(x => x.Id == clientId) ?? throw new Exception("Client with this id does not exist");
                db.Clients.Remove(client);
                db.SaveChanges();
            }
        }
        public static void DelSupply(int supplyId)
        {
            using (InternetStoreContext db = new())
            {
                var supply = db.Supplies.SingleOrDefault(x => x.Id == supplyId) ?? throw new Exception("Supply with this id does not exist");
                db.Supplies.Remove(supply);
                db.SaveChanges();
            }
        }
        public static void DelPurchase(int purchaseId)
        {
            using (InternetStoreContext db = new())
            {
                var purchase = db.Purchases.SingleOrDefault(x => x.Id == purchaseId) ?? throw new Exception("Purchase with this id does not exist");
                db.Purchases.Remove(purchase);
                db.SaveChanges();
            }
        }
        public static void DelCall(int callId)
        {
            using (InternetStoreContext db = new())
            {
                var call = db.Calls.SingleOrDefault(x => x.Id == callId) ?? throw new Exception("Call with this id does not exist");
                db.Calls.Remove(call);
                db.SaveChanges();
            }
        }
    }
}
