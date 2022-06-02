using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program //Main Class.
    {
        public static void Main(string[] args) //Main Method.
        {
            ClassOne assignment = new ClassOne(); //Instantiating the created 'ClassOne' class.

            //

            Console.WriteLine("What number would you like us to do math operations on and return as an integer."); //Prints string.
            int userChoice = Convert.ToInt32(Console.ReadLine()); //Requests 1st user input.
            Console.WriteLine(); //Line Break.

            int varAdd = assignment.Addition(userChoice); //Integer variable. Calls instantiated method. Parameter 'int userChoice'.
            Console.WriteLine(userChoice + " + 12 = " + varAdd); //Prints string, then result.
            Console.WriteLine(); //Line Break.

            //

            Console.WriteLine("Enter a number in decimal form that you would like us to do math operations on and return as the nearest integer."); //Prints string.
            double userChoice2 = Convert.ToDouble(Console.ReadLine()); //Requests 2nd user input.
            double userDecimalEntry = userChoice2; //Giving value of the users entry to a new variable.
            int decimalToInt = Convert.ToInt32(userDecimalEntry); //Converting the users decimal value to an integer.
            Console.WriteLine(); //Line Break.

            double varAddv2 = assignment.Addition(userChoice2); //Double variable. Calls instantiated method. Parameter 'userChoice2'.
            Console.WriteLine(userChoice2 + "+ .12 = " + decimalToInt); //Prints string, then the converted result.
            Console.WriteLine(); //Line Break.

            //

            Console.WriteLine("Enter a string that you would like us to convert to an integer, do math operations on and return as an integer."); //Prints string.
            string userChoice3 = Console.ReadLine();
            Console.WriteLine(); //Line Break.

            string xyz = userChoice3;
            try
            {
                int x = Convert.ToInt32(xyz);
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is invalid.");
            }
            //string varAddv3 = assignment.Addition(userChoice3); //String variable. Calls instantiated method. Parameter 'userChoice

            //

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
