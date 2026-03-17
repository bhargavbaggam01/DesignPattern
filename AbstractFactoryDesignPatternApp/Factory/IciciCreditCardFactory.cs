using AbstractFactoryDesignPatternApp.Implementation.FamilyAIcici;
using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Factory;

internal class IciciCreditCardFactory : ICreditCardFactory
{
    public IMasterCreditCard GetMasterCreditCard()
    {
        return new IciciMasterCreditCard();
    }

    public IVisaCreditCard GetVisaCreditCard()
    {
        return new IciciVisaCreditCard();
    }
}
