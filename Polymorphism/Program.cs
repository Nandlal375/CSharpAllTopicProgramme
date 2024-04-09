using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //=================== Operator Overloading start ========================
    class NewClass
    {
        public int num;
        public string name;

        public static NewClass operator +(NewClass newClass, NewClass newClass1)
        {
            NewClass newClass2 = new NewClass();
            newClass2.name = newClass.name + newClass1.name;
            newClass2.num = newClass.num + newClass1.num;
            return newClass2;
        }
    }
    //=================== Operator Overloading End ========================
    internal class Program
    {
        //================ Method Overloading start ==========================
        //public void Add()
        //{
        //    Console.WriteLine("sum of two number ==> " + (10 + 20));
        //}
        //public void Add(int a, int b)
        //{
        //    Console.WriteLine("sum of two number ==> " + (a + b));
        //}
        //public void Add(int a, int b, int c)
        //{
        //    Console.WriteLine("three of two number ==> " + (a + b + c));
        //}
        //================ Method Overloading end ==========================

        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();
            newClass.num = 120;
            newClass.name = "Nandlal";

            NewClass newClass1 = new NewClass();
            newClass1.num = 100;
            newClass1.name = "Rao";

            NewClass newClass2 = new NewClass();
            newClass2 = newClass + newClass1;
            Console.WriteLine(newClass2.name);
            Console.WriteLine(newClass2.num);

            //Program p = new Program();
            //p.Add();
            //p.Add(100, 200);
            //p.Add(100, 200, 300);
            Console.ReadLine();
        }
    }
}
