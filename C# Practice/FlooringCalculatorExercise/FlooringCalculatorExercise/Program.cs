using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringCalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal Length;
            decimal Width;

            Console.WriteLine();
            Console.WriteLine("Hello, I'm Patrick. Nice to meet you. ");
            Console.WriteLine("This is a calculator exercise in C#");
            Console.WriteLine("A flooring calculator exercise, specifically.");
            Console.WriteLine("So here we're going to ask you to enter a length and width of your room.");
            Console.WriteLine("Then it'll figure out the area, material cost, potential labor cost, and give you a total.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Write("Please enter the length of the room in Feet: ");
            Length = Decimal.Parse(Console.ReadLine());

            Console.Write("Please enter the width of the room in Feet: ");
            Width = Decimal.Parse(Console.ReadLine());

            decimal CostPerSqFt = 1 * Length * Width;

            decimal Area = Length * Width;

            decimal LaborCostPerHour = (Area/5) * (86/4);

            decimal Total = CostPerSqFt + LaborCostPerHour;

            Console.WriteLine("Length: {0} Ft.", Length);
            Console.WriteLine("Width:  {0} Ft.", Width);
            Console.WriteLine("Area:   {0} Sq. Ft.", Area);
            Console.WriteLine("Cost/Sq. Ft.: $1.00");
            Console.WriteLine("Total Material Cost: {0:C}", CostPerSqFt);
            Console.WriteLine("Labor Cost at $86.00/Hour(20 Sq. Ft./Hour): {0:C}", LaborCostPerHour);
            Console.WriteLine("Total: {0:C}", Total);

            Console.ReadLine();
        }
    }
}
