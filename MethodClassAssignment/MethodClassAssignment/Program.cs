using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassOne assignment = new ClassOne(); //Instantiating the created 'ClassOne' class.

            Console.WriteLine("Enter first number:"); //Prints string.
            int userInput1 = Convert.ToInt32(Console.ReadLine()); //Requests 1st user input.

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Enter second number:"); //Prints string.
            int userInput2 = Convert.ToInt32(Console.ReadLine()); //Requests 2nd user input.

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Results:"); //Prints string.
            Console.WriteLine(userInput2); //Prints second user input.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
