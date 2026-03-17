using AdapterDesignPattern;
using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.Interface;
using AdapterDesignPattern.ThirdPartyClass;

ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();

IPaymentProcessor paymentProcessor = new PaymentAdapter(thirdPartyPaymentGateway);
paymentProcessor.pay(100.0);

