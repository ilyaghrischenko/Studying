using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Lesson_19
{
    public class PaymentInvoice : ISerializable
    {
        public decimal DayPayment { get; set; } = 0;
        public uint DaysCount { get; set; } = 0;
        public decimal DayFine { get; set; } = 0;
        public uint DelayedPaymentDaysCount { get; set; } = 0;
        public decimal PaymentAmountWithoutFine { get; private set; } = 0;
        public decimal Fine { get; private set; } = 0;
        public decimal Payment { get; private set; } = 0;

        public PaymentInvoice()
        {
            CalculatePayment();
        }
        public PaymentInvoice(decimal dayPayment, uint daysCount, decimal dayFine, uint delayedPaymentDaysCount)
        {
            DayPayment = dayPayment;
            DaysCount = daysCount;
            DayFine = dayFine;
            DelayedPaymentDaysCount = delayedPaymentDaysCount;
            CalculatePayment();
        }

        private PaymentInvoice(SerializationInfo info, StreamingContext context)
        {
            DayPayment = info.GetDecimal("DayPayment");
            DaysCount = info.GetUInt32("DaysCount");
            DayFine = info.GetDecimal("DayFine");
            DelayedPaymentDaysCount = info.GetUInt32("DelayedPaymentDaysCount");
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("DayPayment", DayPayment);
            info.AddValue("DaysCount", DaysCount);
            info.AddValue("DayFine", DayFine);
            info.AddValue("DelayedPaymentDaysCount", DelayedPaymentDaysCount);
            if (IsSerialize)
            {
                info.AddValue("PaymentAmountWithoutFine", PaymentAmountWithoutFine);
                info.AddValue("Fine", Fine);
                info.AddValue("Payment", Payment);
            }
        }

        public static string Path { get; } = "paymentInvoice.json";
        public static bool IsSerialize { get; } = false/*new Random().Next() > new Random().Next()*/;

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Day payment: ");
            if (!decimal.TryParse(ReadLine(), out decimal value))
            {
                throw new ArgumentException("Error: Invalid value for day payment");
            }
            DayPayment = value;

            Write("Days count: ");
            if (!uint.TryParse(ReadLine(), out uint value1))
            {
                throw new ArgumentException("Error: Invalid value for days count");
            }
            DaysCount = value1;

            Write("Day fine: ");
            if (!decimal.TryParse(ReadLine(), out value))
            {
                throw new ArgumentException("Error: Invalid value for day fine");
            }
            DayFine = value;

            Write("Delayed payment days count: ");
            if (!uint.TryParse(ReadLine(), out value1))
            {
                throw new ArgumentException("Error: Invalid value for delayed payment days count");
            }
            DelayedPaymentDaysCount = value1;

            PaymentAmountWithoutFine = DayPayment * DaysCount;
            Fine = DayFine * DelayedPaymentDaysCount;
            Payment = PaymentAmountWithoutFine * Fine;
        }

        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(Path, jsonString);
        }
        private void CalculatePayment()
        {
            PaymentAmountWithoutFine = DayPayment * DaysCount;
            Fine = DayFine * DelayedPaymentDaysCount;
            Payment = PaymentAmountWithoutFine + Fine;
        }

        public override string ToString()
        {
            return $"Day payment: {DayPayment}, Days count: {DaysCount}, Day fine: {DayFine}, Delayed payment days count: {DelayedPaymentDaysCount}, Payment amount without fine: {PaymentAmountWithoutFine}, Fine: {Fine}, Payment: {Payment}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (PaymentInvoice)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
