using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Factory
{
    internal interface ICreditCardFactory
    {
        IMasterCreditCard GetMasterCreditCard();
        IVisaCreditCard GetVisaCreditCard();
    }
}
