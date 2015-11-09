using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[] arrayInput;

            Console.WriteLine("Hello, I'm Patrick and this program will reverse whatever you type in.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Please enter anything you'd like to be reversed");
                input = Console.ReadLine();
                if (input != null)
                {
                    break;
                }
                Console.WriteLine("Come on, you gotta enter something for me to reverse it.");
            } while (true);


            arrayInput = input.ToCharArray();
            Array.Reverse(arrayInput);
            arrayInput.ToString();

            Console.WriteLine(arrayInput);

            Console.ReadLine();
           

        }
    }
}
