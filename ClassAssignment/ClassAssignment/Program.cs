using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2.
            ClassOne instantiation = new ClassOne(); //Instantiating the created 'ClassOne' class.

            //Step 3.
            Console.WriteLine("Enter a number:"); //Prints string.
            int userInput = Convert.ToInt32(Console.ReadLine()); //Requests user input, then prints their input.

            Console.WriteLine("Here is your number divided by two:"); //Prints string.
            int result = instantiation.methodOne(userInput);
            Console.WriteLine(result); //Prints result.

            ////Step 4.
            //int outputParameters;
            //methodTwo(out outputParameters);
            //Console.WriteLine(outputParameters); //Prints result.

            //Step 5.
            int sum1 = instantiation.methodThree(1, 2);
            Console.WriteLine("The sum of the two values: " + sum1); //Prints string and result.

            int sum2 = instantiation.methodThree(1, 2, 3);
            Console.WriteLine("The sum of the three values: " + sum2); //Prints string and result.
        }
    }
}
