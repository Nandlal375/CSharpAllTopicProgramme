using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInC_
{

    enum Days
    { 
     Sunday,
     Monday,
     Tuesday,
     Wednesday,
     Thursday,
     Friday,
     Saturday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Days.Saturday);
            Console.ReadLine();
        }
    }
}
