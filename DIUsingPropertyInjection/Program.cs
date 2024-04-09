using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUsingPropertyInjection
{
    public interface IAccount
    {
        void Printdetails();
    }

    class CurrentAccount : IAccount
    {
        public void Printdetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }
    class SavingAccount : IAccount
    {
        public void Printdetails()
        {
            Console.WriteLine("Details of Saving Account");
        }
    }
    class Account
    {
        public IAccount account { get; set; }
        public void PrintAccount()
        {
            account.Printdetails();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account();
            account1.account = new CurrentAccount();
            account1.PrintAccount();
            Console.ReadLine();
        }
    }
}
