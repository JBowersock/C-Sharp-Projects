using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //Prints string.

                    Console.WriteLine(); //Line Break.

            //#2 & 3
            Console.WriteLine("Please enter the package weight:"); //Prints string.
            int pkgWeight = Convert.ToInt32(Console.ReadLine()); //Request for user input.
            if (pkgWeight > 50) //If condition.
            {
                Console.WriteLine(); //Line Break.
                Console.WriteLine("We're sorry, your package is too heavy to be shipped via Package Express. Have a good day."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
                return; //Ends program.
            }

                    Console.WriteLine(); //Line Break.

            //#4
            Console.WriteLine("Please enter the package width:"); //Prints string.
            int pkgWidth = Convert.ToInt32(Console.ReadLine()); //Request for user input.

                    Console.WriteLine(); //Line Break.

            //#5
            Console.WriteLine("Please enter the package height:"); //Prints string.
            int pkgHeight = Convert.ToInt32(Console.ReadLine()); //Request for user input.

                    Console.WriteLine(); //Line Break.

            //#6
            Console.WriteLine("Please enter the package length:"); //Prints string.
            int pkgLength = Convert.ToInt32(Console.ReadLine()); //Request for user input.

                    Console.WriteLine(); //Line Break.

            //#7
            int totalSize = pkgWidth + pkgHeight + pkgLength; //Addition.
            if (totalSize > 50) //If condition.
            {
                Console.WriteLine("We're sory, your package is too big to be shipped via Package Express. Have a good day."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
                return; //Ends program.
            }

            //#8
            int pkgSize = pkgWidth * pkgHeight * pkgLength; //Multiplication.
            int sizeTimesWeight = pkgSize * pkgWeight; //Multiplication.
            int divideBy100 = sizeTimesWeight / 100; //Division.

            //#9 & 10
            Console.WriteLine("Your estimated total for shipping this package is: $" + divideBy100); //Prints string.
            Console.WriteLine("Thank you for using Package Express!"); //Prints string.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
