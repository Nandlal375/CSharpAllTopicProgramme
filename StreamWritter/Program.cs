using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWritter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Myfile.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    streamWriter.Write("My New file is Create");
                    Console.WriteLine("Writter Operation is succeedd.......!!");
                }
            }
            Console.ReadLine();
        }
    }
}
