using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAndLamdaExp
{
    internal class Program
    {
        public delegate void Sumresult(int a, int b);
        //public void Sum(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //    //return a + b;
        //}
        static void Main(string[] args)
        {
            
            //Sumresult sumresult = delegate (int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //};

            Sumresult sumresult = (int a, int b) =>
           
                Console.WriteLine(a + b);
                //return a + b;   
            

            //Console.WriteLine(sumresult(500, 500));
            
            sumresult(200, 500);
            //Console.WriteLine(p.Sum(10, 20));
            Console.ReadLine();
        }
    }
}
