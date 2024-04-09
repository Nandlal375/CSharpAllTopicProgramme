using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Myfile.txt";

            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
