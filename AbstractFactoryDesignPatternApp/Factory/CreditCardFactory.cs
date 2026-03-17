using AbstractFactoryDesignPatternApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternApp.Factory
{
    internal class CreditCardFactory
    {
        public ICreditCardFactory GetCreditCard(BankType bankType)
        {
            ICreditCardFactory creditCard = bankType switch
            {
                BankType.HDFC => new HdfcCreditCardFactory(),
                BankType.ICICI => new IciciCreditCardFactory(),
                _ => throw new InvalidDataException($"bank type not implemented"),
            };
            return creditCard;
        }
    }
}
