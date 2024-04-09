using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{

    public sealed class Singleton
    {
        private static Singleton instance;
        private static object obj = new object();
        private Singleton() { }
        public static Singleton GetSingleton()
        {

            if (instance == null)
            {
                lock (obj)
                {
                    Console.WriteLine("obj = " + obj);
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;

        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetSingleton();
            Console.WriteLine("singloten = " + singleton.ToString());
            Console.ReadLine();
        }
    }
}
