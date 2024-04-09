using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInC_
{
    class VisitingEmp : Employee
    {
        public int visitingSalary;
        public int visitingHour;
    }
    class PermanentEmp : Employee
    {
        public int permanentSalary;
        public int permanentHour;
    }
    class Employee
    {
        public int EmpId;
        public string Name;
        public int EmpAge;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmp Asad = new PermanentEmp();
            Asad.Name = "test";
            VisitingEmp Ali = new VisitingEmp();
            Ali.Name = "test1";
            Console.WriteLine(Asad.Name);
            Console.WriteLine(Ali.Name);
            Console.ReadLine();
        }
    }
}
