using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\My Directory";
            string path1 = @"D:\My Directory 2";
            DirectoryInfo dir = new DirectoryInfo(path);
            //dir.Create();
            //dir.CreateSubdirectory("MySubDirectory");
            dir.MoveTo(path1);
            Console.WriteLine("Directory Created Succeffuly.....!!");
            Console.ReadLine();
        }
    }
}
