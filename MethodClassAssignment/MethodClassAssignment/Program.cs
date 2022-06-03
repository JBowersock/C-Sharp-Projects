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
            //Step 2.
            ClassOne assignment = new ClassOne(); //Instantiating the created 'ClassOne' class.

            //Step 3.
            assignment.methodOne(3, 6); //Calling and passing in two integers to class.

            //Step 4.
            assignment.methodOne(userInput1: 15, userInput2: 18); //Calling and specifying parameters by name.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
