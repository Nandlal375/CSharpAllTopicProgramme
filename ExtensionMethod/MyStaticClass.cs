using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{

    static class MyStaticClass
    {
        public static void Func3(this Program p, int i)
        {
            Console.WriteLine("Mystatic class Function three...................!!!" + i);
        }
        public static void Func4(this Program p)
        {
            Console.WriteLine("Mystatic class Function 4...............");
        }
        public static bool Func5(this int i, int value) 
        {
          return i > value;
        }
    }
}
