using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ThirdPartyClass
{
    public class ThirdPartyPaymentGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} through Third Party Payment Gateway.");
        }
    }
}
