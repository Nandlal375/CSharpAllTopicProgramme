using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperties
{
    class University
    {
        private static string _UniversityName;

        public static string UniversityName 
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Empty Value is not Accept");
                }
                else {
                    _UniversityName = value;

                }
            }
            get
            {
                //Console.WriteLine("University name ==> " + _UniversityName);
                return _UniversityName;
            
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //University university = new University();   
            //university.
            University.UniversityName = "Abc University";
            Console.WriteLine(University.UniversityName);
            Console.ReadLine();
        }
    }
}
