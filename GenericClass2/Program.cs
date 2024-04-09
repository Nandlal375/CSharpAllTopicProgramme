using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    class Nandlal<T>
    {
        public T Data { get; set; }
        public T display(T item)
        {
            //Console.WriteLine(item);
            return item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nandlal<string> nandlal = new Nandlal<string>();
            //DataStore<string> dataStore = new DataStore<string>();
            nandlal.Data = "Nandlal prasad rao";
            Nandlal<int> n = new Nandlal<int>();
            Console.WriteLine(n.display(201520));
            Console.WriteLine(nandlal.Data);
            Console.ReadLine();
        }
    }
}
