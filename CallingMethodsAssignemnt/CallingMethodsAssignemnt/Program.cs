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

                Console.WriteLine(); //Line Break.

            Console.WriteLine(userChoice + "+12=" + varAdd); //Prints string, then result.

                Console.WriteLine(); //Line Break.

            Console.WriteLine(userChoice + "-8=" + varSub); //Prints string, then result.

                Console.WriteLine(); //Line Break.

            Console.WriteLine(userChoice + "x3=" + varMul); //Prints string, then result.
            
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
