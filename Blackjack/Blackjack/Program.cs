using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Added this to program.

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text."; //Utilizing File I/O to write text to a document (below).
            ////(Below) Writing text to a file. Because we used the @ symbol at the beginning, we dont have to use double \\ because it's inside a string.
            ////The @ symbol means to 'read literally'.
            //File.WriteAllText(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt", text);
            
            ////Here we are writing text to a file.
            //File.ReadAllText(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt");

            Console.WriteLine("Welcome to Blackjack Table!");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

                Console.WriteLine(); //Line Break.

            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower(); //.ToLower() makes users entry lowercase, making the process easier.

                Console.WriteLine(); //Line Break.

            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame();
                game += player; //Adding a 'player' to the 'game'.
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) //While player is playing and balance is more than zero.
                {
                    game.Play();
                }
                game -= player;

                    Console.WriteLine(); //Line Break.

                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around! Goodbye.");
            Console.Read();
        }
    }
}
