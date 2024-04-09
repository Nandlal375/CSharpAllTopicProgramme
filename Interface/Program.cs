using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEmployee
    {
        //public int MyProperty { get; set; }
      void Show();
    }

    class PartTimeEmployee : IEmployee
    {
        public void Show()
        {
            Console.WriteLine("This class is interface class.....!!!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee employee = new PartTimeEmployee();
            employee.Show();
            Console.ReadLine();
        }
    }
}
 