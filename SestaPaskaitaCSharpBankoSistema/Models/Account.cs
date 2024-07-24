namespace SestaPaskaitaCSharpBankoSistema.Models
{
    public class Account
    {
        public string Number { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Account() { }
        public Account(string number, double balance, List<Transaction> transaction)
        {
            Number = number;
            Balance = balance;
            Transactions = transaction;
        }

        public void Deposit(double amount)
        {
            Transactions.Add(new Transaction(amount, "Deposit"));
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            // cia reikia surasti transakcija
            Balance -= amount;
        }

    }
}
