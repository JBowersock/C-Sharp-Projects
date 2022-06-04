using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Step 1. Create an enum for the days of the week.
        public enum daysOfTheWeek //Enumerator.
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            //Step 4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            try
            {
                //Step 2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter the current day of the week:"); //Prints string.
                string userInput = Console.ReadLine(); //Requests user input.

                //Step 3. Assign the value to a variable of that enum data type you just created.
                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), userInput);

                Console.WriteLine(); //Line Break.
                Console.WriteLine("You entered " + day + ", it's integer is {0}.", (int)day);

                Console.ReadLine(); //Allows window to remain open until user closes.
            }
            catch (SystemException)
            {
                Console.WriteLine(); //Line Break.
                Console.WriteLine("You did not enter an actual day of the week."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
            }
        }
    }
}
