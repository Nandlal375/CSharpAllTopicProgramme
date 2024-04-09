using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverideKeyword
{
    abstract class calculation
    {
        //public virtual int Num1(int a, int b)
        //  {
        //      return a + b;

        //  }
        public abstract void Show();
    }

    //class calculation1 : calculation
    //{
    //    public override int Num1(int a, int b)
    //    {
    //        return (a + b) * 2;

    //    }
    //}

    class calculation1 : calculation
    {
        public override void Show()
        {
            Console.WriteLine("Abstract method");
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            calculation1 c = new calculation1();
            //Console.WriteLine(c.Num1(1, 2));
            //Console.ReadLine();
            c.Show();
            Console.ReadLine();


        }
    }
}
