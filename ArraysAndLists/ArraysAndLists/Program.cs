using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //Arrays
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //This is just a simplified way of doing the block above.

            int[] numArray2 = { 5, 2, 10, 200, 5000 }; //This is an even simpler way of doing the line above.

            numArray2[4] = 4999; //Here we are changing the number of a specific array. (ex: 5000 to 4999).

            Console.WriteLine(numArray2[4]);
            
                Console.WriteLine(); //Line Break

            //Lists (using integers)
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine(intList[0]);

                Console.WriteLine(); //Line Break

            //Lists (using strings)
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("there!");
            stringList.Remove("there!");

            Console.WriteLine(stringList[0]);

            Console.ReadLine();
        }
    }
}
