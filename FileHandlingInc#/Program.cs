using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingInc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\FileHandling.txt";
            string path1 = @"D:\Data\FileHandling.txt";
            if (File.Exists(path))
            {
                //Console.WriteLine("Yes There is a file");
                //string data = File.ReadAllText(path1);   
               File.Copy(path, path1);
       
                Console.WriteLine("Yes Data is Copy............");
            }
            else
            {
                Console.WriteLine("File Not Found.............!!!!!!");
            }
            Console.ReadLine();
        }
    }
}
