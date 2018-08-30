using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num1}*{i}={num1 * i}");
            }
            Console.ReadLine();

            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine($"{num1}*{j}={num1 * j}");
                j++;
            }

            int k = 1;
            do
            {
                Console.WriteLine($"{num1}*{k}={num1 * k}");
                j++;
            } while (j <= 10);

        }
    }
}
