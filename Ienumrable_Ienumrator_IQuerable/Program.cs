using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumrable_Ienumrator_IQuerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employee = new List<Employee>()
            //{
            // new Employee { Id = 1, Name = "Nandlal"},
            // new Employee { Id = 2, Name = "prasad"}
            //};
            //foreach (var item in employee)
            //{
            //    Console.WriteLine(item.Id + "=>" + item.Name);
            //}

            //IQueryable<int, string> s = new IQueryable<string>();
            //s.Append("A");

            List<string> list = new List<string>();
            list.Add("nandlal");
            list.Add("prasad 1203");

            IQueryable<string> query = list.AsQueryable();
            
            foreach (var item in query)
            {
                Console.WriteLine("query =>" + item);
            }


            IEnumerator<string> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {

                Console.WriteLine(enumerator.Current);
            }


            foreach (var item in list)
            {
                Console.WriteLine("item =>" + item);
            }
            Console.ReadLine();
        }
    }
}
