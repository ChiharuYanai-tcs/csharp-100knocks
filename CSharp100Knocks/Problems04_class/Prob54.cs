namespace CSharp100Knocks.Problems04_class
{
    public class Prob54
    {
        public decimal Balance { get; private set; } = 10;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Input must be positive number");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Input must be positive number");
            }
            if (Balance < amount)
            {
                throw new InvalidOperationException("The balance is short");
            }
            Balance -= amount;
        }
    }
}