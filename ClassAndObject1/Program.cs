using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject1
{

    public class Student
    {
        int rollno;
        string name;

        
        public void setrolNumber(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void getNumber()
        {
            Console.WriteLine(this.rollno);
            Console.WriteLine($"Student deatil is :{this.rollno} {this.name}");
            Console.ReadLine();
        }



    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
              Student ali = new Student();
              //Student ali = new Student();
              Console.WriteLine("Please Enter Your roll no.");
              int Srollno = int.Parse(Console.ReadLine());
              Console.WriteLine("Please Entre Your Name");
              string name = Console.ReadLine();

              ali.setrolNumber(Srollno, name);
              ali.getNumber();
        }
    }
}
