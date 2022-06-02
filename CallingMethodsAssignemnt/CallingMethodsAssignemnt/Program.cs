using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like us to do math operations on?"); //Prints string.
            int userChoice = Convert.ToInt32(Console.ReadLine()); //Requests user input.

            Console.WriteLine(userChoice + "+12="); //Prints string.
            Console.WriteLine(Addition); //Prints result.

            Console.WriteLine(userChoice + "-8="); //Prints string.
            Console.WriteLine(Subtract); //Prints result.

            Console.WriteLine(userChoice + "x3="); //Prints string.
            Console.WriteLine(Multiply); //Prints result.
        }
    }
}
