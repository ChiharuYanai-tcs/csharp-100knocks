namespace CSharp100Knocks.Problems04_class
{
    public class Prob60
    {
        public interface IPayment
        {
            void Pay(int amount);
            string PaymentMethodName {get;}
        }

        public class CreditCardPayment : IPayment
        {
            public string PaymentMethodName => "Credit Card";
            public void Pay(int amount)
            {
                Console.WriteLine($"Payment Method: {PaymentMethodName}, Pay: {amount}.");
            }
        }

        public class CashPayment : IPayment
        {
            public string PaymentMethodName => "Cash";
            public void Pay(int amount)
            {
                Console.WriteLine($"Cash Pay: {amount}");
            }
        }
    }
}