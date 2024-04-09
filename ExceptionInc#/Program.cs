using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //====== FormatException Raise this below code start ====

            //Console.WriteLine("Plesa Enter Any Number");
            //try
            //{
            //    string s1 = Console.ReadLine();
            //    int number1 = int.Parse(s1);
            //    Console.WriteLine("Your number is = " + number1);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //Console.ReadLine();
            //====== FormatException Raise this below code End ====

            //====== ArgumentNullException Raise this below code start ====
            //try
            //{
            //    string s1 = null;
            //    int i = int.Parse(s1);
            //    Console.WriteLine(i);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("String is null...........");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            //====== ArgumentNullException Raise this below code End ====

            //==== NullReferenceException start code ===//
            //try
            //{
            //    string name = null;
            //    if (name == null)
            //    {
            //        Console.WriteLine("String is null Again");
            //    }
            //    else
            //    {
            //        Console.WriteLine(name.Length);

            //    }

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("String is Null.........");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine(); 
            //==== NullReferenceException End code ===//

            //=== IndexOutOfRangeException Start code ===//
            //try
            //{
            //    int[] arr = new int[3];
            //    arr[0] = 1;
            //    arr[1] = 2;
            //    arr[2] = 3;
            //    arr[3] = 4;
            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Your Array is Exceed......");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
            //=== IndexOutOfRangeException End code ===//

            
        }
    }
}
