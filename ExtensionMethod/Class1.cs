using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Class1
    {

        public static void display(this Program p)
        {
            Console.WriteLine("class1 other class........!!!!!");
        }
    }
}
