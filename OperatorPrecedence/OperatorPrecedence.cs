using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPrecedence
{
    internal class OperatorPrecedence
    {
        static void Main(string[] args)
        {
            Int32 a = 5 * (5 / 2 + 10 - 2);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
