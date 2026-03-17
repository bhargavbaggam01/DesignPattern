using AdapterDesignPattern.Interface;
using AdapterDesignPattern.ThirdPartyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Adapter
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway _thirdPartyPaymentGateway;
        public PaymentAdapter(ThirdPartyPaymentGateway thirdPartyPaymentGateway)
        {
            _thirdPartyPaymentGateway = thirdPartyPaymentGateway;
        }
        public void pay(double amount)
        {
            _thirdPartyPaymentGateway.MakePayment(amount);
        }
    }
}
