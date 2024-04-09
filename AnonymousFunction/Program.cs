using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    delegate void Mydelegates(int a);
    internal class Program
    {
        //public static void ShowNumber(int a)
        //{
        //    Console.WriteLine(a);
        //}
        static void Main(string[] args)
        {
            Mydelegates d = delegate (int a)
            {
                Console.WriteLine(a);
            };
            d.Invoke(100);
            Console.ReadLine();
        }
    }
}
