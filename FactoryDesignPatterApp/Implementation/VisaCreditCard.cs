using FactoryDesignPatterApp.Interfaces;

namespace FactoryDesignPatterApp.Implementation
{
    internal class VisaCreditCard : ICreditCard
    {
        public double GetBalance()
        {
            return 10;
        }

        public string GetCardType() => "VISA";

        public void PayBill(double amount)
        {
            Console.WriteLine($"Bill pay : {amount}");
        }
    }
}
