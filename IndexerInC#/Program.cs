using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerInC_
{

    class Indexerdemo
    {
        private int[] arr = new int[3];

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < arr.Length)
                {
                    if (value > 0)
                    {
                        arr[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Zero OR negative value is not Contain");
                    }
                }
                else {
                    Console.WriteLine("Index is Invalid........!!");
                }
            }
            get {
            
               return arr[index];   
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Indexerdemo indexerdemo = new Indexerdemo();
            indexerdemo[0] = 5;
            Console.WriteLine("MyArray is ==> " + indexerdemo[0]);
            Console.ReadLine();

        }
    }
}
