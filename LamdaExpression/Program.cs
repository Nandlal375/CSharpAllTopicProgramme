using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    public delegate int Mydelegate(int num);
        
    internal class Program
    {
        
        //public static void Add()
        //{
        //    Console.WriteLine("My add operation");
        //}
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //int[] list = { 12, 16 };
            //List<int> evenNumbers = list.FindAll(x => (x * x));
            //var square = list.Select(x => x * x);

            //foreach (var x in square)
            //{

            //    Console.WriteLine(x);
            //}

           
            Mydelegate mydelegate = (num) =>
            {
                return num;
                //Console.WriteLine("number ==>" + num);
            };
            //var result = number1 => number1 * number1;



            //Mydelegate mydelegate = delegate (int num)
            //{
            //    Console.WriteLine("number ==>" + num);
            //};
            Console.WriteLine(mydelegate(450));
            
            //Mydelegate mydelegate = new Mydelegate(Program.Add);
            //mydelegate.Invoke();
            Console.ReadLine();
        }
    }
}
