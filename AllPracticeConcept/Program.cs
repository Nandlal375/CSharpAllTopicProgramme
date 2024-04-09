using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPracticeConcept
{
   public interface MyInterface
    {
        void Show1();
    }
    public class Nandlal : MyInterface
    {
        public void Show1()
        {
            Console.WriteLine("First method");
        }
    }

    public class Prasad : MyInterface
    {
        public void Show1()
        {
            Console.WriteLine("Second method");
        }
    }

    class Common
    {
        public MyInterface myinterface;
        public Common(MyInterface myInterface)
        { 
            this.myinterface = myInterface;
        }
        public void ShowAllMethod() {
            myinterface.Show1();
        }

        //Nandlal n = new Nandlal();
        //Prasad p = new Prasad();
        //public void AllMethod()
        //{
        //    n.Show1();
        //    p.Show2();
        //}
    }
    internal class Program
        {
            
            static void Main(string[] args)
            {
             MyInterface myInterface = new Nandlal();
             Common c = new Common(myInterface);   
             c.ShowAllMethod();
             Console.ReadLine();
        }
    }
}
