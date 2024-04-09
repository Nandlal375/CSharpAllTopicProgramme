using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\FileStream.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                string data = "this is File Stream Object";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                fileStream.Write(buffer, 0, data.Length);
                Console.WriteLine("File Created......!!");
            }
            Console.ReadLine(); 
        }
    }
}
