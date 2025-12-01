using System.Security.Cryptography.X509Certificates;
using CSharp100Knocks.Problems04_class;
using Microsoft.VisualBasic;

namespace CSharp100Knocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Prob60.IPayment payment = new Prob60.CreditCardPayment();
            payment.Pay(270);

            Prob60.IPayment payment2 = new Prob60.CashPayment();
            payment2.Pay(5000);
        }
    }
    
    
}