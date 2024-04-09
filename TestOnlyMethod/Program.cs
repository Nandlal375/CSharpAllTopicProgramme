using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnlyMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"


            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8
        }
    }
}
