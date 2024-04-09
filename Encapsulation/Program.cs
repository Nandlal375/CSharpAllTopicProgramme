using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private string Name;
        private int Age;
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.Name = name;
            }
          
        }
        public void GetName()
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your Name is ==> " + this.Name);
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("");
            person.GetName();
          Console.ReadLine();
        }
    }
}
