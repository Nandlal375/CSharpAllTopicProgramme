using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndPassByReference
{
    internal class Program
    {
        public static void Nandu(int a) 
        {
            a = a + 10;
            Console.WriteLine("Value is {0}", a);
        }
        static void Main(string[] args)
        {
            int value = 50;
            Nandu(value);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
