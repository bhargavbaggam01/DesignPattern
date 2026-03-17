using FactoryDesignPatterApp.Interfaces.Factory;

namespace FactoryDesignPatterApp.Implementation;

internal class MasterCreditCard : ICreditCard
{
    public double GetBalance()
    {
        return 20;
    }

    public string GetCardType() => "MasterCard";

    public double GetLimit()
    {
        throw new NotImplementedException();
    }

    public void PayBill(double amount)
    {
        throw new NotImplementedException();
    }

    string ICreditCard.GetType()
    {
        throw new NotImplementedException();
    }
}
