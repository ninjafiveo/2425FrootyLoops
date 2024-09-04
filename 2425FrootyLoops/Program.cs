using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2425FrootyLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for_loops();
            //foreach_loops();
            while_loops();

            Console.ReadLine();
        }

        static void for_loops()
        {
            Console.Write("What number would you like to count to? ");
            double the_count = double.Parse(Console.ReadLine());

            // for(initializer; condition; iterator)
            for (int i = 0; i <= the_count; i = i + 100)
            {
                Console.WriteLine($"The count = {i}");
            }
        }

        static void foreach_loops()
        {
            string[] candy = { "M & M", "Reese Peanut Butter Cups", "Reese Pieces", "Snickers", "Pay Day", "Baby Ruth", "Nestle Crunch", "Nutter Butter", "Milky Way"};

            foreach (string item in candy) { 
                Console.WriteLine($"Candy in stock: {item}");
            }
        }

        static void while_loops() {
            int numberOfNinjas = 0;
            while (numberOfNinjas <= 100)
            {
                 Console.WriteLine($"There are {numberOfNinjas} in this room. Can you count them?");
                numberOfNinjas++;
            }
        }





    }
}
