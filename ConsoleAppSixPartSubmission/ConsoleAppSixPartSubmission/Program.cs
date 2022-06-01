using System;
using System.Collections.Generic;

namespace ConsoleAppSixPartSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One
            Console.WriteLine("Please enter a word:");
            string[] stringColor = { "Red", "White", "Blue", "Silver", "Green" };
            string userInput = Console.ReadLine();
            Console.WriteLine(); // Line Break.

            for (int a = 0; a < stringColor.Length; a++) //Per the assignment, this loop is intended to add the user input to each list string.
            {
                stringColor[a] = stringColor[a] + " " + userInput; //This could be do shorter, as so: 'stringColor[a] += " " + userInput;'
            }
            foreach (string v in stringColor) //Per the assignment, this loop is just to print the string. Verifying addion of user input to list in loop prior.
            {
                Console.WriteLine(v);
            }
                       Console.WriteLine(); //Line Break.

            //Part Two: Infinite Loop *Intenitonally Infinite* (Pt.1)
            //var b = true;
            //while (b)
            //{
            //    Console.WriteLine("Hey ma! Look. No Hands!");
            //}

            //Part Two: Infinite Loop *Fixed* (Pt.2)
            var b = true;
            while (b)
            {
                Console.WriteLine("Hey ma! Look. No Hands!");
                b = false; //This stops the infinite loop.
            }
                        Console.WriteLine(); //Line Break.

            //Part Three (Pt.1)
            int[] oneThroughTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int c = 0; c < oneThroughTen.Length; c++)
            {
                Console.WriteLine(oneThroughTen[c]);
            }
                        Console.WriteLine(); //Line Break.

            //Part Three (Pt.2)
            //int[] elevenThroughTwenty = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //for (int d = 0; d <= elevenThroughTwenty.Length; d++)
            //{
            //    Console.WriteLine(elevenThroughTwenty[d]);
            //}

            for (int i = 0; i <= 5; i++) //Note: '<=' does not work with .Length.
            {
                Console.WriteLine(i);
            }
                        Console.WriteLine(); //Line Break.

            //Part Four
            List<string> petList = new List<string>() { "dog", "cat", "fish" };
            Console.WriteLine("Name one of three common household pets (lowercase):");
            string userGuess = Console.ReadLine();
            Console.WriteLine(); //Line Break.
            for (int z = 0; z < 1; z++)
            {
                if (userGuess == "dog")
                {
                    Console.Write("Index Number: " + petList.IndexOf("dog"));
                    Console.ReadLine();
                    break;
                }
                if (userGuess == "cat")
                {
                    Console.Write("Index Number: " + petList.IndexOf("cat"));
                    Console.ReadLine();
                    break;
                }
                if (userGuess == "fish")
                {
                    Console.Write("Index Number: " + petList.IndexOf("fish"));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Sorry, that's not on the list.");
                    Console.ReadLine();
                    break;
                }
            }
                        Console.WriteLine(); //Line Break.

            //Part Five
            List<string> musicGenre = new List<string>() { "rock", "metal", "country", "rap", "rock" };
            Console.WriteLine("Select a music genre;\n1. rock\n2. metal\n3. country\n4. rap\n5. rock");
            Console.WriteLine(); //Line Break.
            Console.WriteLine("Your selection: ");
            string genreGuess = Console.ReadLine();
            Console.WriteLine(); //Line Break.
            for (int x = 0; x < musicGenre.Count; x++)
            {
                if (!musicGenre.Contains(genreGuess)) //Contains means 'does the user entry match any of the values in the array/list'.
                {
                    Console.WriteLine("Your choice is not in the list");
                    break;
                }
                if (musicGenre[x] == genreGuess)
                {
                    Console.WriteLine("Index Number: " + x);
                }
            }

            //Part Six
            List<string> toolBox = new List<string>() { "screwdriver", "wrench", "ratchet", "wrench", "socket" };
            Console.WriteLine(); //Line Break.
            List<string> dupeList = new List<string>();

            foreach (string tool in toolBox)
            {
                if (dupeList.Contains(tool))
                {
                    Console.WriteLine(tool + " : Item already displayed.");
                }
                else
                {
                    Console.WriteLine(tool + " : Item displayed once.");
                    dupeList.Add(tool);                
                }
            }
            Console.ReadLine();
        }
    }
}
