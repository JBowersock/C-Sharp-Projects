using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12; //Note: You could also do 'isGuessed = False'. What we have instead, is a simply a truer version of false.

            do //Do-While Loop. This executes the code block at least once. In this instance, allowing 'That is correct!' string if user guesses 12 on the first try.
            {
                switch (number) //Switch Statement. It selects one of many code blocks to be executed.
                {
                    case 62: //A specific parameter (number).
                        Console.WriteLine("You guessed 62. Try again."); //Prints string.
                        Console.WriteLine("Guess a number:"); //Prints string.
                        number = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                    case 29: //A specific parameter (number).
                        Console.WriteLine("You guessed 29. Try again."); //Prints string.
                        Console.WriteLine("Guess a number:"); //Prints string.
                        number = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                    case 55: //A specific parameter (number).
                        Console.WriteLine("You guessed 55. Try again."); //Prints string.
                        Console.WriteLine("Guess a number:"); //Prints string.
                        number = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                    case 12: //A specific parameter (number).
                        Console.WriteLine("You guessed 12. That is correct!"); //Prints string.
                        isGuessed = true; //Changes while to True.
                        break; //Stops program switch, condition met.
                    default: //Sets direction for all incorrect selections.
                        Console.WriteLine("You are wrong."); //Prints string.
                        Console.WriteLine("Guess a number:"); //Prints string.
                        number = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                }
            }
            while (isGuessed == false); //Note: You could also do (!isGuessed). The '!' means 'while equals false'.

            Console.ReadLine(); //Allows window to stay open until user closes.
        }
    }
}
