using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer Array Iteration
            //'int[]' means Integer Array. 'testScores' is the name we're giving it. The numbers in the {} are the indexes.
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //For Loop (note: For Loops have 3 conditions: the Starting Value, the Duration of the loop, and finally the Counter)
            //'int i' is the 'Starting Value'. The 'i' could be any letter, we chose 'i' and 0 for this example. You can start at any number.
            //'i < testScores .Length' means the For Loop will an equal amound of times as how many indexes there are in testScores (which is 9 times.)
            //i++ means after each full loop, an integer of 1 will be added to 'i'.
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

                        Console.WriteLine(); //Line Break.

            //String Array Iteration
            //'string[]' means String Array. 'names' is the name we're giving it. The strings in the {} are the indexes.
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //For Loop (note: For Loops have 3 conditions: the Starting Value, the Duration of the loop, and finally the Counter)
            //'int j' is the 'Starting Value'. The 'j' could be any letter, we chose 'j' and 0 for this example. You can start at any number.
            //'j < testScores .Length' means the For Loop will an equal amound of times as how many indexes there are in testScores (which is 4 times.)
            //j++ means after each full loop, an integer of 1 will be added to 'j'.
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }

                        Console.WriteLine(); //Line Break.

            //Integer List Itteration
            List<int> testScores2 = new List<int>();
            testScores2.Add(98);
            testScores2.Add(99);
            testScores2.Add(81);
            testScores2.Add(72);
            testScores2.Add(70);

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

                        Console.WriteLine(); //Line Break.

            //String List Itteration
            List<string> names2 = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            foreach (string name in names2)
            {
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                }
            }

                        Console.WriteLine(); //Line Break

            //
            List<int> testScores3 = new List<int>() { 98, 99, 85, 70, 82, 34 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores3)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count); //Counts how many passing scores there were.

            Console.ReadLine();
        }
    }
}
