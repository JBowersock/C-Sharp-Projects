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
            int varAdd = ClassOne.Addition(); //Integer variable. Calls a method from 'ClassOne'.
            int varSub = ClassOne.Subtract(); //Integer variable. Calls a method from 'ClassOne'.
            int varMul = ClassOne.Multiply(); //Integer variable. Calls a method from 'ClassOne'.

            Console.WriteLine("What number would you like us to do math operations on?"); //Prints string.
            int userChoice = Convert.ToInt32(Console.ReadLine()); //Requests user input.

            Console.WriteLine(userChoice + "+12="); //Prints string.
            Console.WriteLine(varAdd); //Prints result.

            Console.WriteLine(userChoice + "-8="); //Prints string.
            Console.WriteLine(varSub); //Prints result.

            Console.WriteLine(userChoice + "x3="); //Prints string.
            Console.WriteLine(varMul); //Prints result.
        }
    }
}
