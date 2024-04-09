using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassInC_
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;

        static Product()
        { 
          ProductId = 1;
          ProductName = "Saloon";
        }

        public static void GetAllProduct()
        {
            Console.WriteLine(ProductId);
            Console.WriteLine(ProductName);

        }
    }
     

    internal class Program
    {
        static void Main(string[] args)
        {
            Product.GetAllProduct();
            Console.ReadLine();
        }
    }
}
