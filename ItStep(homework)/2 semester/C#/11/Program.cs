using System.Security.AccessControl;
using static System.Console;

namespace _11
{
    internal class Program
    {
        //task 3
        /*
        static void AccountReplenishmentHandler(object? sender, decimal money)
        {
            if (sender == null) throw new Exception();
            if (sender is not CreditCard) throw new Exception();

            (sender as CreditCard).Amount += money;
            WriteLine($"New amount: {(sender as CreditCard).Amount}");
        }
        static void AccountChargeHandler(object? sender, decimal money)
        {
            if (sender == null) throw new Exception();
            if (sender is not CreditCard) throw new Exception();

            (sender as CreditCard).Amount -= money;
            WriteLine($"New amount: {(sender as CreditCard).Amount}");
        }
        static void UsingCreditFundsHandler(object? sender, EventArgs s)
        {
            WriteLine("Start of using credit funds");
        }
        static void ReachingLimitAmountHandler(object? sender, EventArgs s)
        {
            WriteLine("Reaching limit amount");
        }
        static void PinChangeHandler(object? sender, EventArgs s)
        {
            Write("Pin: ");
            (sender as CreditCard).Pin = ReadLine();
        }
        */

        //task 4
        static DayTemperature GetMaxTempDay(List<DayTemperature> days)
        {
            int indexMaxAvg = 0;
            int avg = days[0].Highest - days[0].Lowest;
            for (int i = 0; i < days.Count; ++i)
            {
                int thisAvg = days[i].Highest - days[i].Lowest;
                if (thisAvg > avg)
                {
                    avg = thisAvg;
                    indexMaxAvg = i;
                }
            }
            return days[indexMaxAvg];
        }

        static void Main(string[] args)
        {
            try
            {
                //task 1
                //виконав у попередньому завданні

                //task 2
                //виконав у попередньому завданні

                //task 3
                /*
                CreditCard creditCard = new CreditCard("123", "L.L.L", new Validity(), "345", 5000, 10000);

                creditCard.AccountReplenishment += AccountReplenishmentHandler;
                creditCard.AccountCharge += AccountChargeHandler;
                creditCard.UsingCreditFunds += UsingCreditFundsHandler;
                creditCard.ReachingLimitAmount += ReachingLimitAmountHandler;
                creditCard.PinChange += PinChangeHandler;

                creditCard.Input();
                creditCard.Show();

                creditCard.AddMoney(13);
                creditCard.Show();

                creditCard.TakeMoney(14);
                creditCard.Show();

                creditCard.TakeMoney(9999);
                creditCard.Show();

                creditCard.TakeMoney(2);
                creditCard.Show();
                */

                //task 4
                /*
                List<DayTemperature> dayTemperatures = new List<DayTemperature>
                {
                    new DayTemperature(50, 10),
                    new DayTemperature(40, 20),
                    new DayTemperature(30, 10),
                    new DayTemperature(20, 4)
                };

                WriteLine($"Day with max variance: {GetMaxTempDay(dayTemperatures)}");
                */

                WriteLine();
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
