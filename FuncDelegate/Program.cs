using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{

    class Number
    {
        public int Add(int a, int b)
        { 
           return a + b;    
        }
        public void Name()
        {
            Console.WriteLine("Nandlal prasad");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Func<int, int, int> delegatefun = n.Add;
            Console.WriteLine(delegatefun(10, 20));
            Action a = n.Name;
            a();
            Console.ReadLine();
        }
    }
}
