namespace SestaPaskaitaCSharpBankoSistema.Models
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Type { get; set; }

        public Transaction() { }
        public Transaction(double amount, string type)
        {
            Amount = amount;
            Type = type;
        }
    }
}
