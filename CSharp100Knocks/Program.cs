using CSharp100Knocks.Problems04_class;

namespace CSharp100Knocks
{
    class Problem
    {
        static void Main(string[] args)
        {
            var account = new Prob54();
            account.Deposit(1000);
            Console.WriteLine(account.Balance);
            account.Withdraw(100);
            Console.WriteLine(account.Balance);
        }
    }
}