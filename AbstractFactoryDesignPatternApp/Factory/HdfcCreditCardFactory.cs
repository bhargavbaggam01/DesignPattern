using AbstractFactoryDesignPatternApp.Implementation.FamilyBHDFC;
using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Factory
{
    internal class HdfcCreditCardFactory : ICreditCardFactory
    {
        public IMasterCreditCard GetMasterCreditCard()
        {
            return new HdfcMasterCreditCard();
        }

        public IVisaCreditCard GetVisaCreditCard()
        {
            return new HdfcVisaCreditCard();
        }
    }
}
