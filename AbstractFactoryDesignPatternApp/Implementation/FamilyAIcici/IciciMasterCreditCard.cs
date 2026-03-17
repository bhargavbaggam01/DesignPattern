using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Implementation.FamilyAIcici
{
    internal class IciciMasterCreditCard : IMasterCreditCard
    {
        public string GetType() => $"{BankType.ICICI} {CardType.MASTERCARD}";

        public double GetLimit() => 20;


    }
}
