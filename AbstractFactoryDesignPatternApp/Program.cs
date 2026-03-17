using AbstractFactoryDesignPatternApp.Factory;

namespace AbstractFactoryDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creditCardFactory = new CreditCardFactory();
            var creditCard = creditCardFactory.GetCreditCard(BankType.ICICI);
            Console.WriteLine($"your card {creditCard.GetVisaCreditCard().GetType()} have limit {creditCard.GetVisaCreditCard().GetLimit()}");
            var creditCard2 = creditCardFactory.GetCreditCard(BankType.HDFC);
            Console.WriteLine($"your card {creditCard2.GetMasterCreditCard().GetType()} have limit {creditCard2.GetMasterCreditCard().GetLimit()}");
        }
    }
}
