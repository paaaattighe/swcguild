using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        {

            int startYear;
            int endYear;

            Console.WriteLine("Hello, this is Patrick. This program is called Leap Years.");
            Console.WriteLine("It tells you when the leap years are... yup.");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Anyways, enter a year to start with:");
                startYear = Convert.ToInt32(Console.ReadLine());

                if (startYear < 2015)
                {
                    break;
                }

                Console.WriteLine("Please enter a year before this year.");
                Console.ReadLine();
            } while (true);

            do
            {
                Console.WriteLine("Cool, {0} is a terrible year. Now please enter a better year to end with(must be a year greater than the year you just chose):", startYear);
                endYear = Convert.ToInt32(Console.ReadLine());

                if (endYear > startYear)
                {
                    break;
                }

                Console.WriteLine("Please enter a year greater than the first one you chose...");
                Console.ReadLine();
            } while (true);

            Console.WriteLine("Okay, so {0} and {1}", startYear, endYear);


            for(int i = startYear; i <= endYear; i++)
            {
                Console.WriteLine(i);
                if ((i % 4 == 0) && !(i % 100 == 0) || (i % 400 == 0))
                {
                    Console.WriteLine("{0} is a leap year", i);
                }
            }

            Console.ReadLine();

        }
    }
}
