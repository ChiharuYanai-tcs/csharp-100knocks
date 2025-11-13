namespace CSharp100Knocks.Problems04_class
{
    public class Prob53
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Input must be positive number");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Input must be positive number");
            }
            if (balance < amount)
            {
                throw new InvalidOperationException("The balance is short");
            }
            balance -= amount;
        }

    }
}