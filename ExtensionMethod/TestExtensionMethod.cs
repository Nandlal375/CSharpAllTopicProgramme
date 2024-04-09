using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class TestExtensionMethod
    {
        static void Main()
        {
            Program program = new Program();
            program.Fun1();
            program.Fun2();
            program.Func3(20);
            program.Func4();
            program.display();
            int i = 20;
            bool result = i.Func5(10);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
