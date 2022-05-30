using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n \t Hello on a tab.";
            string fileName = "C:\\Users\\Jesse"; //In order to display a '\' within quotes, you have to use two. (ex. \\)

            bool trueOrFalse = name.Contains("s"); //Asks 'does name (assined above) contain letter "s"', which it does. So it would be True.
            trueOrFalse = name.EndsWith("s"); //Asks 'does name (assined above) end with letter "s"', which it doesnt. So it would be False.

            int length = name.Length; //.Length counts the amount of letters inside of name (assigned as 'Jesse'), the result is 5.

            name = name.ToUpper(); //.ToUpper converts name (assigned above) text all to upper case. Result: 'JESSE'.
            name = name.ToLower(); //.ToLower converts name (assigned above) text all to lower case. Result: 'jesse'.

            StringBuilder sb = new StringBuilder(); //Creating an instance of the class StringBuilder.
            sb.Append("My name is Jesse"); //Dynamic object that can expand/collapse with the expensive memory overhead.

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
