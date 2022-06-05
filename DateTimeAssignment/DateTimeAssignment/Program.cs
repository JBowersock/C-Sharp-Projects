using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Added to program.

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1.
            Console.WriteLine(DateTime.Now); //Prints DateTime.

                Console.WriteLine(); //Line Break.

            //Step 2.
            Console.WriteLine("Please enter a number:"); //Prints string.
            int userInput = Convert.ToInt32(Console.ReadLine()); //Request user input.

                Console.WriteLine(); //Line Break.

            //Step 3.
            Console.WriteLine("If we advance the clock by " + userInput + " hours, it will be:"); //Prints string and value.
            Console.WriteLine(DateTime.Now.AddHours(userInput)); //Prints DateTime plus user input (in this case, hours).

            Console.ReadLine(); //Allows console to remain open until user closes.
        }
    }
}
