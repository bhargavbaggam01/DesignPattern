using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Implementation.FamilyBHDFC
{
    internal class HdfcVisaCreditCard : IVisaCreditCard
    {
        public string GetType() => $"{BankType.HDFC} {CardType.VISA}";

        public double GetLimit() => 110;
    }
}
