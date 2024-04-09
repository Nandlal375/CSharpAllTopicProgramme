using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullColeaseOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Adil";
            string result = name ?? "Anonyoums";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
