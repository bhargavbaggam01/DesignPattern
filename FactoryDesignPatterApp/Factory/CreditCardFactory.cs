using FactoryDesignPatterApp.Implementation;
using FactoryDesignPatterApp.Interfaces;

namespace FactoryDesignPatterApp.Factory
{
    internal class CreditCardFactory : ICreditCardFactory
    {
        public ICreditCard GetCreditCard(CardType cardType)
        {
            ICreditCard creditCard = cardType switch
            {
                CardType.MASTERCARD => new MasterCreditCard(),
                CardType.VISA => new VisaCreditCard(),
                _ => throw new InvalidDataException($"credit type not implemented"),
            };
            return creditCard;
        }
    }
}
