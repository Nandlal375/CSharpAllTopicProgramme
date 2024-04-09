using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Person
    {
        public void Show1()
        {
            Console.WriteLine("This is the method of Person class");
        }
    }
    interface Employee
    {
        void Show2();
    }

    class Teacher : Person, Employee
    {
        public void Show2()
        {
            Console.WriteLine("This is method of employee interface...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Show1();
            teacher.Show2();
            Console.ReadLine();

        }
    }
}
