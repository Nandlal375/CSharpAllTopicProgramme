using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesWithGetSet
{
    class Student
    {
        public int Id { get; set; } 
      //private int _StdId;
      //private string _Stdname;

      //  public int StdId
      //  {
      //      set {
      //          if (value <= 0)
      //          {
      //              Console.WriteLine("Id can't be zero or negative");
                   
      //          }
      //          else {
      //              this._StdId = value;
      //          }
      //      }
      //      get { 
                
      //          return this._StdId; 
      //      }
            
      //  }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 10;
            Console.WriteLine(s.Id);
            Console.ReadLine();
            //Student s = new Student();
            //s.StdId = -10;
            //if (s.StdId == 0 || s.StdId < 0)
            //{ 
             
            //}
            //else
            //{
            //    Console.WriteLine(s.StdId);
            //}
            Console.ReadLine();
        }
    }
}
