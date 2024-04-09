using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureInC_
{
    public class Program
    {
        public void Show() {
            Console.WriteLine("Struct Message");
        }
        static void Main(string[] args)
        {
             Program program = new Program();
             program.Show();
            Console.ReadLine();
        }
    }
}
