using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjectionInC_
{

    //====================== Tight Coupling In C# Start ======================
    //class CurrentAccount
    //{
    //    public void Printdetail()
    //    {
    //        Console.WriteLine("Detail of Current Account");
    //    }
    //}
    //class SavingAccount
    //{
    //    public void Printdetail()
    //    {
    //        Console.WriteLine("Detail of Saving Account");
    //    }
    //}
    //class Account
    //{
    //    CurrentAccount ca = new CurrentAccount();
    //    SavingAccount sa = new SavingAccount();

    //    public void PrintAccount()
    //    {
    //        ca.Printdetail();   
    //        sa.Printdetail();
    //    }
    //}
    //====================== Tight Coupling In C# End ======================

    //==================== DI Using Constructor Injection // Loose Coupling Start =======================

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
        private IAccount account1;
        public Account(IAccount account)
        {
            this.account1 = account;
        }
        public void PrintAccount() 
        {
         account1.Printdetails();
        }
    }

    //==================== DI Using Constructor Injection End =======================
    internal class Program
    {
        static void Main(string[] args)
        {
            //========== Tight Coupling start =======
            //Account account = new Account();
            //account.PrintAccount();
            //Console.ReadLine();
            //Console.WriteLine("hello");
            //========== Tight Coupling End =======
            

            //==================== DI Using Constructor Injection Start =======================
            IAccount ca = new CurrentAccount();
            Account account = new Account(ca);
            account.PrintAccount();

            //IAccount sa = new SavingAccount();
            //Account account1 = new Account(sa);
            //account1.PrintAccount();
            //==================== DI Using Constructor Injection End =======================
            Console.ReadLine();
        }
    }
}
