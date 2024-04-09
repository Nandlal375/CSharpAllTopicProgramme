using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{

    public class Student
    {
        public static void Fun1()
        { 
        
        for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Student = " + i);
            }
        }
    }
    internal class Program
    {
        public static void Fun1()
        {
            Console.WriteLine("thread =" + Thread.CurrentThread);
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func1 =" + i);
                
            }

        }
     public static void Fun2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func2 = " + i);
                if (i == 25)
                {
                    Thread.Sleep(1000);
                    
                    Console.WriteLine("Sleep Mode");
                }

                
            }

        }
        public static void Fun3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func3 = " + i);
               
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Fun1);
            Thread t2 = new Thread(Fun2);
            Thread t3 = new Thread(Fun3);
            t1.Start();
            t2.Start();
            t3.Start();
           
            //Program.Fun1();
            //Program.Fun2(); 
            //Program.Fun3();
            Console.ReadLine();
        }
    }
}
