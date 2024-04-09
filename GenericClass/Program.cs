using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Stack myStack = new Stack();
            //myStack.Push("One");
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push("two");
            //foreach (object item in myStack) {
            //    Console.WriteLine(item);
            //}
            //ArrayList arrayList = new ArrayList();
            //arrayList.AddRange(myStack);
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine(arrayList[2]);
            //Console.ReadLine();
            //Hashtable ht = new Hashtable();
            //ht.Add("one", 1);
            //ht.Add(2, "two");
            //Console.WriteLine(ht["one"]);
            //Console.WriteLine(ht[2]);
            //Console.ReadLine();
            Employee employee = new Employee()
            {
                age = 1,
                name = "Test"
            };

            List<Employee> Employee = new List<Employee>();
            Employee.Add(employee);
            foreach (var item in Employee) {
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
            }
            Console.ReadLine();
            //var primeNumbers = new List<int>();
            //primeNumbers.Add(1);
            //primeNumbers.Add(3);
            //primeNumbers.Insert(1, 55);
            //primeNumbers.Add(5);
            //primeNumbers.Add(7);
            //for (int i = 0; i < primeNumbers.Count; i++)
            //{
            //    Console.WriteLine(primeNumbers[i]);
            //}
            //Console.WriteLine("No of elelemts: " + primeNumbers.Count);
            //Console.ReadLine();
            //Dictionary<int, string> numberNames = new Dictionary<int, string>();
            //numberNames.Add(1, "One"); //adding a key/value using the Add() method
            //numberNames.Add(2, "Two");
            //numberNames.Add(3, "Three");
            //foreach (KeyValuePair<int, string> kvp in numberNames)
            //    Console.WriteLine(kvp.Key.ToString() + " => " + kvp.Value);
            //Console.ReadLine(); 
        }
    }
}
