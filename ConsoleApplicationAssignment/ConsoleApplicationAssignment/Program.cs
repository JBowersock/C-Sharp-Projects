using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Requests a number, then multiply by 50.
            Console.WriteLine("1. Enter a number, and we'll multiply it by 50: "); //Writes string to screen requesting user input.
            int num1 = Convert.ToInt32(Console.ReadLine()); //User input section.
            int num1answer = num1 * 50; //Multiplies user input by 50.
            Console.WriteLine("Result: " + num1answer); //Writes result of calculation above to screen.
            Console.WriteLine(); //Line Break.

            //2. Requests a number, then adds 25.
            Console.WriteLine("2. Enter a number, and we'll add 25: "); //Writes string to screen requesting user input.
            int num2 = Convert.ToInt32(Console.ReadLine()); //User input section.
            int num2answer = num2 + 25; //Adds 25 to user input.
            Console.WriteLine("Result: " + num2answer); //Writes result of calculation above to screen.
            Console.WriteLine(); //Line Break.

            //3. Requests a number, then divides by 12.5.
            Console.WriteLine("3. Enter a number, and we'll divide it by 12.5: "); //Writes string to screen requesting user input.
            int num3 = Convert.ToInt32(Console.ReadLine()); //User input section.
            double num3answer = num3 / 12.5; //Divides user input by 12.5.
            Console.WriteLine("Result: " + num3answer); //Writes result of calculation above to screen.
            Console.WriteLine(); //Line Break.

            //4. Requests a number, then checks if it's greater than 50.
            Console.WriteLine("4. Enter a number, and we'll see if it's greater than 50: "); //Writes string to screen requesting user input.
            int num4 = Convert.ToInt32(Console.ReadLine()); //User input section.
            bool num4answer = num4 > 50; //Checks to see if user input is greater than 50.
            Console.WriteLine("Result: " + num4answer); //Writes result of calculation above to screen.
            Console.WriteLine(); //Line Break.

            //5. Requests a number, then divides it by 7 and displays only the remainder.
            Console.WriteLine("5. Enter a number, and we'll divide it by 7 and display only the remainder: "); //Writes string to screen requesting user input.
            int num5 = Convert.ToInt32(Console.ReadLine()); //User input section.
            int num5answer = num5 % 7; //Divides user input by 7, then finds remainder.
            Console.WriteLine("Result: " + num5answer); //Writes result of calculation above to screen.
            Console.WriteLine(); //Line Break.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
