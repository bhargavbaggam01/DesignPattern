using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Implementation.FamilyBHDFC
{
    internal class HdfcMasterCreditCard : IMasterCreditCard
    {
        public string GetType() => $"{BankType.HDFC} {CardType.MASTERCARD}";

        public double GetLimit() => 150;

    }
}
