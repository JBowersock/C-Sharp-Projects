using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main()
        {
            //1, 3 & 5. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen. Add Comments.
            string[] stringArray = { "Red", "White", "Blue", "Silver", "Black" }; //String array.
            Console.WriteLine("Select a number between 0 and 4:"); //Prints string.
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice > 4) //If statement.
            {
                Console.WriteLine(); //Line Break.
                Console.WriteLine("You chose a number that doesnt not exist!"); //Prints string.
                Console.WriteLine("Press Enter to exit."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
                return; //Prevents further use of program.
            }
            else
            {
                Console.WriteLine(stringArray[userChoice]); //Prints user choice.
            }

                    Console.WriteLine(); //Line Break.

            //2, 3 & 5. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen. Add Comments.
            int[] intArray = { 2, 4, 6, 8, 10 }; //Integer array.
            Console.WriteLine("Select another number between 0 and 4:"); //Prints string.
            int userChoice2 = Convert.ToInt32(Console.ReadLine());
            if (userChoice2 > 4) //If statement.
            {
                Console.WriteLine(); //Line Break.
                Console.WriteLine("You chose a number that doesnt not exist!"); //Prints string.
                Console.WriteLine("Press Enter to exit."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
                return; //Prevents further use of program.
            }
            else
            {
                Console.WriteLine(intArray[userChoice2]); //Prints user choice.
            }

                    Console.WriteLine(); //Line Break.

            //4 & 5. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen. Add Comments.
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("there!");
            stringList.Add("It sure is nice today!");
            stringList.Add("Nice enough for a long walk");
            stringList.Add("or even a bike ride.");
            Console.WriteLine("Select a number between 0 and 4:"); //Prints string.
            int userChoice3 = Convert.ToInt32(Console.ReadLine());
            if (userChoice3 > 4) //If statement.
            {
                Console.WriteLine(); //Line Break.
                Console.WriteLine("You chose a number that doesnt not exist!"); //Prints string.
                Console.WriteLine("Press Enter to exit."); //Prints string.
                Console.ReadLine(); //Allows window to remain open until user closes.
                return; //Prevents further use of program.
            }
            else
            {
                Console.WriteLine(stringList[userChoice3]); //Prints user choice.
            }

            Console.WriteLine(); //Line Break.
            Console.WriteLine("Press Enter to exit."); //Prints string.
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}