using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string Name;
        public double Grosspay;
        double TaxDeduction = 0.1;
        double Netsalary;

        public Employee(int Eid, string Ename, double EgrossSalary)
        {
            this.EmpId = Eid;
            this.Name = Ename;
            this.Grosspay = EgrossSalary;
        }
        private void CalculateSalary()
        {
            if (Grosspay > 30000)
            {
                Netsalary = Grosspay - (TaxDeduction * Grosspay);
                Console.WriteLine("Your salary is = " + Netsalary);
            }
            else
            {
                Console.WriteLine("grosspay = " + Grosspay);
            }
        }
        public void ShowSalary()
        { 
         CalculateSalary();
        
        }
          

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(333, "Ali Khna", 40000);
            employee.ShowSalary();
            Console.ReadLine();
        }
    }
}
