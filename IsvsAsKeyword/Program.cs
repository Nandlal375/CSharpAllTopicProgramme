using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsvsAsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj = "hiii";
            string s2 = "hiii";
            //string s1 = obj as ;
            object b = s2 as object;
            //Console.WriteLine(s1);
            Console.WriteLine(b);
            Console.ReadLine();

            object obj = "Adil";
            bool check = obj is string;
            Console.WriteLine(check);
            Console.ReadLine();


        }
    }
}
