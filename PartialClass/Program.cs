using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Test";
            student.LastName = "TestL";
            StudentPartial partial = new StudentPartial();
            partial.FirstName = "Nandlal Prasad";
            partial.LastName = "Rao";
            Console.WriteLine(partial.GetCompleteName());
            Console.WriteLine(student.GetCompleteName());
            Console.ReadLine();
        }
    }
}
