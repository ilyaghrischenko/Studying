using Quiz;
using System.Net;
using System.Text.Json;
using System.Xml.Linq;
using static System.Console;

namespace Lesson_19
{
    internal class Program
    {
        static PaymentInvoice GetFromFile()
        {
            PaymentInvoice paymentInvoice = JsonSerializer.Deserialize<PaymentInvoice>(File.ReadAllText(PaymentInvoice.Path));
            if (paymentInvoice == null) return new();
            return paymentInvoice;
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            try
            {
                User user = new();

                int choice = -1;
                Write("0 - Exit\n1 - Authorisation\n2 - Registration\n: ");
                if (!int.TryParse(ReadLine(), out choice))
                {
                    throw new Exception("Error: Invalid option");
                }
                if (choice != 0 && choice != 1 && choice != 2) throw new Exception("Error: Invalid option");

                switch (choice)
                {
                    case 0:
                        WriteLine("Exit...");
                        break;
                    case 1:
                        AuthorisationRegistration.Authorisation(user);
                        break;
                    case 2:
                        AuthorisationRegistration.Registration(user);
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            //task 2
            PaymentInvoice paymentInvoice = new(200, 10, 10, 5);
            paymentInvoice.Show();
            paymentInvoice.Save();
        }
    }
}
