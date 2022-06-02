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
            Console.WriteLine(); //Line Break.

            Console.WriteLine("Enter second number (optional):"); //Prints string.
            string userChoice2 = Console.ReadLine(); //Requests 2nd user input.
            int num = -1;
            Console.WriteLine(); //Line Break.
            if (!int.TryParse(userChoice2, out num))
            {
                Console.WriteLine("Your entries combined equal:"); //Prints string.
                Console.WriteLine(userChoice1); //Prints result.
            }
            else
            {
                Console.WriteLine("Your entries combined equal:"); //Prints string.
                int x = Int32.Parse(userChoice2); //Converting 'userChoice2' to integer for calculation below.
                var result = userChoice1 + x; //Assigning calculation to a varaible.
                Console.WriteLine(result); //Prints result.
            }
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
