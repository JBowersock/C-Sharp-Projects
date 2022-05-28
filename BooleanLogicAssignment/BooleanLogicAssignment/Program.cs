using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); //Prints string.
            int userAge = Convert.ToInt32(Console.ReadLine()); //Requests user input.
            bool ageQuestion = userAge > 15; //Boolean.

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Have you ever had a DUI? (True/False):"); //Prints string.
            bool duiQuestion = Convert.ToBoolean(Console.ReadLine()); //Boolean, requests user input.

                Console.WriteLine(); //Line Break.

            Console.WriteLine("How many speeding tickets do you have?"); //Prints string.
            int userTicket = Convert.ToInt32(Console.ReadLine()); //Requests user input.
            bool ticketQuestion = userTicket < 4; //Boolean.

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Qualification Result:"); //Prints string.
            Console.WriteLine(ageQuestion && ticketQuestion != duiQuestion); //Boolean Logic, using 'And' and 'Doesnt Not Equal' Operators.

            Console.ReadLine();
        }
    }
}
