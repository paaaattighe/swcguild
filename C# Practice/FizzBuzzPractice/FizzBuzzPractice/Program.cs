using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, I'm Patrick and this is Fizz Buzz Practice in C#.");
            Console.WriteLine("It's going to count from 1 to 100."); 
            Console.WriteLine("If the number is divisible by 3, it'll say Fizz.");
            Console.WriteLine("If the number is divisible by 5 it'll say Buzz.");
            Console.WriteLine("If both, then it'll say FizzBuzz");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0 )
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i +" Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
