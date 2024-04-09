using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorOverLoding
{
    class ParentClass
    {
        public int Id;
        public static string Name;
        public static int fees = 500;
        public static void Fees()
        {
            //Console.WriteLine(Id);
            
            Console.WriteLine(fees);
        }
        public void MainMethod()
        {
            Console.WriteLine("Without Static member == " + fees);
            
        }
     //public ParentClass() {
     //       Console.WriteLine("Default contructor");
     //   }
     //   public ParentClass(int a)
     //   {
     //       Console.WriteLine(a);
     //   }
     //   public ParentClass(int a, int b)
     //   {
     //       Console.WriteLine(a + b);
     //   }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           ParentClass p = new ParentClass();
            p.Id = 10;
            ParentClass p1 = new ParentClass();
            p1.Id = 20;
            p.MainMethod();
            ParentClass.Fees();
            ParentClass.Name = "Abc School";
            ParentClass.Name = "Abc School";
            Console.WriteLine(p.Id + "<==========>" + p1.Id);
            Console.WriteLine(ParentClass.Name);
            //ParentClass p1 = new ParentClass(10);
            //ParentClass p2= new ParentClass(10, 20);
            Console.ReadLine();
        }
    }
}
