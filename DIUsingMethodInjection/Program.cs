using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUsingMethodInjection
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
        public void PrintAccount(IAccount account)
        {
            account.Printdetails();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            IAccount account1 = new CurrentAccount();
            account.PrintAccount(account1);
            Console.ReadLine(); 

        }
    }
}
