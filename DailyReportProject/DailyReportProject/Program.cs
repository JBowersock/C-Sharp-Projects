using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //The line below is the companies name.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine(Environment.NewLine); //Line Break.

            //The line below is the form type.
            Console.WriteLine("Student Daily Report");

            //The block below asks for user reply.
            Console.WriteLine("1. What is your name?");
            string yourName = Console.ReadLine();

            //The block below asks for user reply.
            Console.WriteLine("2. What course are you on?");
            string yourCourse = Console.ReadLine();

            //The block below asks for user reply.
            Console.WriteLine("3. What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            //The block below asks for user reply.
            Console.WriteLine("4. Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //The block below asks for user reply.
            Console.WriteLine("5. Were there any positive experiences you'd like to provide? Please give specifics.");
            string yourExp = Console.ReadLine();

            //The block below asks for user reply.
            Console.WriteLine("6. Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            //The block below asks for user reply.
            Console.WriteLine("7. How many hours did you study today?");
            int yourHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine); //Line Break.

            //The line below sends users a message once form is completed.
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.WriteLine(Environment.NewLine); //Line Break.

            //The block below is the user input displayed all at once after submissions are made.
            Console.WriteLine("Daily Report Entries;"); //This line is here to declare where the Daily Report result form begins.
            Console.WriteLine("1. What is your name?: " + yourName); //This line returns the user input to Question 1.
            Console.WriteLine("2. What course are you on?: " + yourCourse); //This line returns the user input to Question 2.
            Console.WriteLine("3. What page number?: " + pageNum); //This line returns the user input to Question 3.
            Console.WriteLine("4. Do you need help with anything?: " + needHelp); //This line returns the user input to Question 4.
            Console.WriteLine("5. Were there any positive experiences you'd like to provide?: " + yourExp); //This line returns the user input to Question 5.
            Console.WriteLine("6. Is there any other feedback you'd like to provide?: " + yourFeedback); //This line returns the user input to Question 6.
            Console.WriteLine("7. How many hours did you study today?: " + yourHours); //This line returns the user input to Question 7.
            Console.ReadLine(); //This line allows window to remain open until user choses to close.
        }
    }
}
