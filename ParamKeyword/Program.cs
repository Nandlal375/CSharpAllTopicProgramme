using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamKeyword
{
    internal class Program
    {
        public static int Sum(params int[] nums)
        {
            Console.WriteLine(nums.Length);
            int add = 0;
            foreach (int num in nums)
            {
                add += num;
            }
            return add;
        }
        static void Main(string[] args)
        {
            //int[] arr = {10, 20 }; 
            int j = 0;
            for (int i = 0; i < i + 1; i++)
            {
                Console.WriteLine("Please Enter your Number");
                j += int.Parse(Console.ReadLine());
                Console.WriteLine("Your Result is = " + Program.Sum(j));
            }

            Console.ReadLine();
        }
    }
}
