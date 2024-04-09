using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Person
    {
        //int a = 10;
        public string Name;
        public int Age;
        public long PhoneNumber;
       public abstract void PrintDetail();
    }
    class Student : Person
    {
        public int rollno;
        public long fees;

        public override void PrintDetail()
        { 
          string name = this.Name;
          int age = this.Age;
          long phoneNumber = this.PhoneNumber;
            Console.WriteLine("Student name ==" + name);
            Console.WriteLine("Student age ==" + age);
            Console.WriteLine("Student phonenumber ==" + phoneNumber);
            Console.WriteLine("Student rollno = " + rollno);
            Console.WriteLine("Student fees = " + fees);
            //Console.WriteLine("number = " + a);
        }
    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetail()
        {
            string name = this.Name;
            int age = this.Age;
            long phoneNumber = this.PhoneNumber;
            Console.WriteLine("Teacher name ==" + name);
            Console.WriteLine("Teacher age ==" + age);
            Console.WriteLine("Teacher phonenumber ==" + phoneNumber);
            Console.WriteLine("Teacher qualification = " + qualification);
            Console.WriteLine("Teacher salary = " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Anas = new Student();
            Anas.rollno = 1;    
            Anas.fees = 1000;
            Anas.Name = "Anas";
            Anas.Age = 10;
            Anas.PhoneNumber = 7845102030; 
            Anas.PrintDetail();


            Console.WriteLine("------------------------------------------------------");
            Teacher Asad = new Teacher();
            Asad.salary = 15000;
            Asad.Age = 45;
            Asad.PhoneNumber = 9856841020;
            Asad.Name = "Asad";
            Asad.qualification = "Msc.";
             Asad.PrintDetail();
            Console.ReadLine();
        }
    }
}
