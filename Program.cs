using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            t num1 = 0;
            Console.WriteLine("enter a number to find odd or even");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("your name is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }
            Console.ReadLine();

        }
    }
}
