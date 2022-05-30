using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1. Prints title string.
            Console.WriteLine("Anonymous Income Comparison Program"); //Prints string.

            Console.WriteLine(); //Line Break.

            //#2. Prints string and requests two inputs.
            Console.WriteLine("Person 1"); //Prints string.
            Console.WriteLine("Hourly Rate: "); //Prints string.
            int hourlyPay1 = Convert.ToInt32(Console.ReadLine()); //Requests user input.
            Console.WriteLine("Hours Worked: "); //Prints string.
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine()); //Requests user input.

            Console.WriteLine(); //Line Break.

            //#3. Prints string and requests two inputs.
            Console.WriteLine("Person 2"); //Prints string.
            Console.WriteLine("Hourly Rate: "); //Prints string.
            int hourlyPay2 = Convert.ToInt32(Console.ReadLine()); //Requests user input.
            Console.WriteLine("Hours Worked: "); //Prints string.
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine()); //Requests user input.

            Console.WriteLine(); //Line Break.

            //#4. Prints string and displays calculation.
            Console.WriteLine("Annual salary of Person 1:"); //Prints string.
            int salaryP1 = hourlyPay1 * hoursWorked1 * 52; //Multiplies user inputs.
            Console.WriteLine(salaryP1); //Prints result.

            Console.WriteLine(); //Line Break.

            //#5. Prints string and displays calculation.
            Console.WriteLine("Annual salary of Person 2:"); //Prints string.
            int salaryP2 = hourlyPay2 * hoursWorked2 * 52; //Multiplies user inputs.
            Console.WriteLine(salaryP2); //Prints result.

            Console.WriteLine(); //Line Break.

            //#6. Prints string and boolean.
            Console.WriteLine("Does Person 1 make more money than Person 2?"); //Prints string.
            bool trueOrFalse = salaryP1 > salaryP2; //Boolean.
            Console.WriteLine(trueOrFalse); //Prints result.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
