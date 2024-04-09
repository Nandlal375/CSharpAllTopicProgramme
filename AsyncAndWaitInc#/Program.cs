using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndWaitInc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();       
        }
        public static async void Task1()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 1 Execute.............");
                Thread.Sleep(4000);
                Console.WriteLine("Complete task 1");
            });
          
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Execute.............");
                Thread.Sleep(2000);
                Console.WriteLine("Complete task 2");
            });

        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Execute.............");
                Thread.Sleep(3000);
                Console.WriteLine("Complete task 3");
            });
            
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Execute.............");
                Thread.Sleep(1000);
                Console.WriteLine("Complete task 4");
            });
            
        }
    }
}
