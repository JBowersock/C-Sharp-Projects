using System;
using System.Collections.Generic;

namespace ConsoleAppSixPartSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One
            string[] stringColors = { "Red", "White", "Blue", "Silver", "Green" };
            Console.WriteLine(": ");
            string userText = Console.ReadLine();
            Console.WriteLine(); // Line Break.
            for (int a = 0; a < stringColors.Length; a++)
            {
                Console.WriteLine(stringColors[a] + " " + userText);
            }
                        Console.WriteLine(); //Line Break.

            //Part Two: Infinite Loop (Pt.1)
            //var b = true;
            //while (b)
            //{
            //    Console.WriteLine("Hey ma! Look. No Hands!");
            //}

            //Part Two: Infinite Loop (Pt.2)
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
                if (oneThroughTen[c] < 7)
                {
                    Console.WriteLine(oneThroughTen[c]);
                }
            }
                        Console.WriteLine(); //Line Break.

            //Part Three (Pt.2)
            int[] elevenThroughTwenty = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int d = 0; d < elevenThroughTwenty.Length; d++)
            {
                if (elevenThroughTwenty[d] <= 18)
                {
                    Console.WriteLine(elevenThroughTwenty[d]);
                }
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
            for (int x = 0; x < 1; x++)
            {
                if (genreGuess == "rock")
                {
                    Console.WriteLine("Index Number: " + musicGenre.IndexOf("rock"));
                    Console.ReadLine();
                    break;
                }
                if (genreGuess == "metal")
                {
                    Console.WriteLine("Index Number: " + musicGenre.IndexOf("metal"));
                    Console.ReadLine();
                    break;
                }
                if (genreGuess == "country")
                {
                    Console.WriteLine("Index Number: " + musicGenre.IndexOf("country"));
                    Console.ReadLine();
                    break;
                }
                if (genreGuess == "rap")
                {
                    Console.WriteLine("Index Number: " + musicGenre.IndexOf("rap"));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that's not on the list.");
                    Console.ReadLine();
                    break;
                }
            }

            //Part Six
            List<string> toolBox = new List<string>() { "screwdriver", "wrench", "ratchet", "wrench", "socket" };
            Console.WriteLine("Name something you'd find in a toolbox (lowercase):");
            string toolGuess = Console.ReadLine();
            Console.WriteLine(); //Line Break.
            foreach (string y in toolBox)
            {
                if (toolGuess == "screwdriver")
                {
                    Console.WriteLine("Index Value: " + toolBox.IndexOf("screwdriver"));
                    Console.ReadLine();
                    break;
                }
                if (toolGuess == "wrench")
                {
                    Console.WriteLine("Index Value: " + toolBox.IndexOf("wrench"));
                    Console.ReadLine();
                    break;
                }
                if (toolGuess == "ratchet")
                {
                    Console.WriteLine("Index Value: " + toolBox.IndexOf("ratchet"));
                    Console.ReadLine();
                    break;
                }
                if (toolGuess == "socket")
                {
                    Console.WriteLine("Index Value: " + toolBox.IndexOf("socket"));
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that's not on the list.");
                    Console.ReadLine();
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
