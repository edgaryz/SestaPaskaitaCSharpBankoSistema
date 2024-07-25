using SestaPaskaitaCSharpBankoSistema.Models;

namespace SestaPaskaitaCSharpBankoSistema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer alex = new Customer("Alex Luther");
            Customer john = new Customer("John Miller");

            Account account1 = new Account("LT2536", 0.00);
            Account account2 = new Account("LT57296", 0.00);
            Account account3 = new Account("LT57246", 0.00);
            Account account4 = new Account("LT87296", 0.00);

            alex.AddAccount(account1);
            alex.AddAccount(account2);
            john.AddAccount(account3);
            john.AddAccount(account4);

            account1.Withdraw(400);
            account2.Deposit(1000);
            account3.Withdraw(250);
            account4.Deposit(5000);

            Console.WriteLine(alex.GetTotalBalance());
            Console.WriteLine(john.GetTotalBalance());

        }
    }
}
