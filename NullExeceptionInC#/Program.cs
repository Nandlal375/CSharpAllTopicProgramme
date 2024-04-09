using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullExeceptionInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                if (name == null)
                {
                    Console.WriteLine("String is null");
                 
                }
                else
                {
                    Console.WriteLine("String is not null");
                    Console.WriteLine(name.Length);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("String is null");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }
    }
}
