using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorPractice
{
    public class Program
    {
        private static void Main(string[] args)
        {

        
            
            
            

            Console.WriteLine("Hello, this is a tip calculator program");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Write("Please enter the total order amount: ");
            decimal total = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Total cost of your meal: {0:C}", total);
            Console.Write("Okay now what percentage would you like to tip your server: ");
            decimal tip = Convert.ToDecimal(Console.ReadLine());

            if (tip < 20)
            {
                Console.WriteLine(
                    "Sooo... {0}%? Lemme teach you some manners and bump it up to 20%(food service is tough man)", tip);
                tip = 20;
            }

            decimal percentage = tip/100;

            decimal tipAmount = percentage*total;

            decimal totalWithTip = tipAmount + total;

            Console.WriteLine("Meal Total: {0:C}", total);
            Console.WriteLine("Your tip amount: {0}%", tip);
            Console.WriteLine("Your Grand total: {0:C}", totalWithTip);

            Console.ReadLine();
        }
    }
}
