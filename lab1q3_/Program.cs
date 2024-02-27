using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1q3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a positive integer");
            int num = int.Parse(Console.ReadLine());

            if (num <0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Exesum(num);
            }
            Console.ReadLine();
        }
         static void Exesum(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num; i++) 
            {
                 sum = sum + i;
            }
            Console.WriteLine($"addition from 1 to {num} is {sum}");
        }
    }
}
