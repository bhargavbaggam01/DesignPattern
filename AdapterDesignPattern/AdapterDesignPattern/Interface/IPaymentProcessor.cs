using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Interface
{
    internal interface IPaymentProcessor
    {
        void pay(double amount);
    }
}
