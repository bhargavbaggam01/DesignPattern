using FactoryDesignPatterApp.Factory;

namespace FactoryDesignPatterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory creditCardFactory = new CreditCardFactory();
            var creditCard = creditCardFactory.GetCreditCard(CardType.VISA);
            Console.WriteLine($"your card {creditCard.GetCardType()} have balance {creditCard.GetBalance()}");

            creditCard = creditCardFactory.GetCreditCard(CardType.MASTERCARD);
            Console.WriteLine($"your card {creditCard.GetCardType()} have balance {creditCard.GetBalance()}");
        }
    }
}
