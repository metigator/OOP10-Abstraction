namespace AbstractionWithInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account1 = new Savingccount();
            account1.AccountNumber = "1111";
            account1.Balance = 6000;

            account1.Deposit(100);
            account1.Withdraw(1000);

        }

    }

    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal Balance { get; set; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    public class CheckingAccount : IBankAccount
    {
        private const decimal DailyWithdrawalLimit = 5000;

        public string AccountNumber { get; set; }
        public decimal Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Deposit(decimal amount)
        {
            //implementation details
            if (amount < 0)
                throw new InvalidOperationException();

            Balance += amount;
        }
        public override void IBankAccount(decimal amount)
        {
            //implementation details 

            if (amount < 0)
                throw new InvalidOperationException();

            if (amount > DailyWithdrawalLimit)
                throw new InvalidOperationException();

            Balance -= amount;
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Savingccount : BankAccount
    {
        private const decimal DailyWithdrawalLimit = 2000;
        public override void Deposit(decimal amount)
        {
            //implementation details
            if (amount < 0)
                throw new InvalidOperationException();

            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            //implementation details

            if (amount < 0)
                throw new InvalidOperationException();

            if (amount > DailyWithdrawalLimit)
                throw new InvalidOperationException();

            Balance -= amount;
        }
    }
}