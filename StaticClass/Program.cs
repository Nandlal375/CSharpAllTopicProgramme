using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Product
    {
        public static int Watch = 10;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.Watch);
            Console.ReadLine();
        }
    }
}
