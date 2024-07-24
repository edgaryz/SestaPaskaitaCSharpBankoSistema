namespace SestaPaskaitaCSharpBankoSistema.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer() { }

        public Customer(string name, List<Account> account)
        {
            Name = name;
            Accounts = account;
        }


    }
}
