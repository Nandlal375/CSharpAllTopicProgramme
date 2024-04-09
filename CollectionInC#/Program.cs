using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInC_
{

    class Example {

        public static void ShowArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3};
            //string[] arr2 = { "Ram", "Syam", "Radhe" };
            Example.ShowArray(arr);
            //Example.ShowArray(arr2);
            Console.ReadLine();

        }
    }
}
