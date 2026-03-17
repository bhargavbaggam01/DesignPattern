using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Implementation.FamilyAIcici
{
    internal class IciciVisaCreditCard : IVisaCreditCard
    {
        public string GetType() => $"{BankType.ICICI} {CardType.VISA}";

        public double GetLimit() => 10;
    }
}
