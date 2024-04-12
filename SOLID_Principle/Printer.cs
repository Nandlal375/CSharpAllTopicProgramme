using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    public class Printer
    {
        public void Print(IShape circle)
        {
            Console.WriteLine(circle);
        }
    }
}
