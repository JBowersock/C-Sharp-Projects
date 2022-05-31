using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 98, 96, 84, 70, 82, 34 }; //Integer List

            Console.WriteLine("Enter a number to divide each number in the list by:"); //Prints string.

            int userNumber = Convert.ToInt32(Console.ReadLine()); //Requests user entry.

            Console.WriteLine(); //Line Break.
            Console.WriteLine("Results:"); //Prints string.
            try
            {
                for (int i = 0; i < numberList.Count; i++) //For Loop.
                {
                int result = numberList[i] / userNumber;
                Console.WriteLine(result);
                }
            }
            catch (FormatException ex) //Catch for if user tries to divide by zero.
            {
                Console.WriteLine("Please divide by a whole number.");
            }
            catch (DivideByZeroException ex) //Catch for if user tries to divide by zero.
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //Finally happens regardless of wether a Catch executes or not, it will always run AS well as have a database log.
            {
                Console.WriteLine(); //Line Break;
                Console.WriteLine("Program has emerged from the try/catch block and continuing execution.");
                Console.ReadLine(); //Allows window to remain open until user closes.
            }
        }
    }
}

