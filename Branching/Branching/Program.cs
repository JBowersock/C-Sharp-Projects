using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            int currentTemperature = 80;
            int roomTemperature = 70;
            
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperature < roomTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }

              Console.WriteLine(); //Line Break.

            //#2. Same as above, but using the 'Ternary Operator' system.
            int currentTemperatureB = 80;
            int roomTemperatureB = 70;

            string comparisonResults = currentTemperatureB == roomTemperatureB ? "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonResults);

               Console.WriteLine(); //Line Break.

            //#3
            int roomTemperatureC = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are located?");
            int currentTemperatureC = Convert.ToInt32(Console.ReadLine());

            if (currentTemperatureC == roomTemperatureC)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperatureC > roomTemperatureC)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperatureC < roomTemperatureC)
            {
                Console.WriteLine("It is colder than room temperature.");
            }

               Console.WriteLine(); //Line Break.

            Console.ReadLine();
        }
    }
}
