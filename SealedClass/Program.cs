using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{

    sealed class MyStore
    {
        public void Item()
        {
            Console.WriteLine("book item........!!");
        }
    }

    //class MyStore1 : MyStore
    //{
    //    public void Item1()
    //    {
    //        Console.WriteLine("book item second class........!!");
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStore myStore = new MyStore();
            myStore.Item();
            Console.ReadLine();
        }
    }
}
