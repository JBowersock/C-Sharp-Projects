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
            ClassOne assignment = new ClassOne(); //Instantiating the created 'ClassOne' class.

            Console.WriteLine("What number would you like us to do math operations on?"); //Prints string.
            int userChoice = Convert.ToInt32(Console.ReadLine()); //Requests user input.

            int varAdd = assignment.Addition(userChoice); //Integer variable. Calls instantiated method. Parameter 'int userChoice'.
            int varSub = assignment.Subtract(userChoice); //Integer variable. Calls instantiated method. Parameter 'int userChoice'.
            int varMul = assignment.Multiply(userChoice); //Integer variable. Calls instantiated method. Parameter 'int userChoice'.

            Console.WriteLine(userChoice + "+12="); //Prints string.
            Console.WriteLine(varAdd); //Prints result.

            Console.WriteLine(userChoice + "-8="); //Prints string.
            Console.WriteLine(varSub); //Prints result.

            Console.WriteLine(userChoice + "x3="); //Prints string.
            Console.WriteLine(varMul); //Prints result.
        }
    }
}
