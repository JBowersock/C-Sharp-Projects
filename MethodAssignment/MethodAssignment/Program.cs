using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        public static void Main(string[] args) //(note: made public).
        {
            ClassOne assignment = new ClassOne(); //Instantiating the created 'ClassOne' class.


            Console.WriteLine("Enter first number:"); //Prints string.
            int userChoice1 = Convert.ToInt32(Console.ReadLine()); //Requests 1st user input.


            try
            {
                Console.WriteLine("Enter second number (optional):"); //Prints string.
                int userChoice2 = Convert.ToInt32(Console.ReadLine()); //Requests 2nd user input.
                int result = assignment.methodOne(userChoice1, userChoice2);//Integer variable. Calls instantiated method. Parameter 'int userChoice1 and userChoice2'.
                Console.WriteLine("Result is: " + result); //Prints string and result,
            }
            catch (Exception)
            {
                int result = assignment.methodOne(userChoice1); //Integer variable. Calls instantiated method. Parameter 'int userChoice1'.
                Console.WriteLine("Result is: " + result); //Prints string and result.
            }


            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
