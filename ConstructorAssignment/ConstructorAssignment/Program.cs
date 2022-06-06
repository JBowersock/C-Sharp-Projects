using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1.
            const string color1 = "Red"; //Assigning a value.
            Console.WriteLine("The first color is {0}.", color1); //Prints string and value.

                Console.WriteLine(); //Line Break

            //Step 2.
            var color2 = "Yellow"; //Assigning a value.
            Console.WriteLine("The second color is {0}.", color2); //Prints string and value.

            Console.WriteLine(); //Line Break

            //Step 3.
            Console.WriteLine("The color Orange comes from combining {0} and {1}!", color1, color2); //Prints string and values.

            Console.ReadLine(); //Allows console to remain open until user closes.
        }
    }
}
