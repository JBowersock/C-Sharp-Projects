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
            decimal userChoice2 = Convert.ToDecimal(Console.ReadLine()); //Requests 2nd user input.
            int decimalToInt = assignment.Addition(userChoice2);
            Console.WriteLine("result of the method is: " + decimalToInt); //Prints string and variable.
            Console.WriteLine(); //Line Break.

            //

            Console.WriteLine("Enter a string that you would like us to convert to an integer, do math operations on and return as an integer."); //Prints string.
            string userChoice3 = Console.ReadLine(); //Requests 3rd user input.
            Console.WriteLine(); //Line Break.
            int varAddv3 = assignment.Addition(userChoice3); //String variable. Calls instantiated method. Parameter 'userChoice
            Console.WriteLine(varAddv3); //Prints variable.

            //

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
