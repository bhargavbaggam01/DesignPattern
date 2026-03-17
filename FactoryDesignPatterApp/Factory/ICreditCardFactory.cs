using FactoryDesignPatterApp.Interfaces;

namespace FactoryDesignPatterApp.Factory
{
    internal interface ICreditCardFactory
    {
        ICreditCard GetCreditCard(CardType cardType);
    }
}
