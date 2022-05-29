using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("What number issue did Thor first appear in comics?"); //Prints string.
            int numberA = Convert.ToInt32(Console.ReadLine());
            bool guessIssueA = false; //Note: You could also do 'isGuessed = False'. What we have instead, is a simply a truer version of false.

            while (guessIssueA == false) //Note: You could also do (!isGuessed). The '!' means 'while equals false'.
            {
                switch (numberA) //Switch Statement. It selects one of many code blocks to be executed.
                {
                    case 83:
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("You guessed it! Thor first appeared in 'Journey to the Mystery no.83'!"); //Prints string.
                        guessIssueA = true; //Changes while to True.
                        break; //Stops program switch, condition met.
                    default: //Sets direction for all incorrect selections.
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("Sorry, that's the wrong answer!"); //Prints string.
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("What number issue did Thor first appear in comics?"); //Prints string.
                        numberA = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                }
            }

            //#2
            Console.WriteLine(); //Line Break (from switch above).
            Console.WriteLine("Now, which number issue did Wolverine first appear in comics?"); //Prints string.
            int numberB = Convert.ToInt32(Console.ReadLine());
            bool guessIssueB = false; //Note: You could also do 'isGuessed = False'. What we have instead, is a simply a truer version of false.

            do //Do-While Loop. This executes the code block at least once. In this instance, allowing 'That is correct!' string if user guesses 12 on the first try.
            {
                switch (numberB) //Switch Statement. It selects one of many code blocks to be executed.
                {
                    case 181:
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("You guessed it! Wolverine first appeared in 'The Incredible Hulk no.181'!"); //Prints string.
                        guessIssueB = true; //Changes while to True.
                        break; //Stops program switch, condition met.
                    default: //Sets direction for all incorrect selections.
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("Sorry, that's the wrong answer!"); //Prints string.
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("What number issue did Wolverine first appear in comics?"); //Prints string.
                        numberB = Convert.ToInt32(Console.ReadLine());
                        break; //Stops program switch, condition met.
                }
            }
            while (guessIssueB == false); //Note: You could also do (!isGuessed). The '!' means 'while equals false'.

            Console.ReadLine(); //Allows window to stay open until user closes.
        }
    }
}
