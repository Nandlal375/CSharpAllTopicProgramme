using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInC_
{
    
    internal class Program
    {
        public delegate void Calculation(int a, int b);
        public void Addition(int a, int b)
        {
            Console.WriteLine("result ==> " + (a + b));
        }
        public void Substraction(int a, int b)
        {
            Console.WriteLine("result ==> " + (a - b));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Calculation c = new Calculation(p.Addition);
            c.Invoke(300, 200);
            Console.WriteLine("target ==>" + c.Target);
            Console.WriteLine("methode =>" + c.Method.Attributes);
            //Calculation c1 = new Calculation(p.Substraction);
            //or below line
            //c = Substraction;
            //c1(70, 30);
            Console.ReadLine();
        }
    }
}
