using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Added this to program.
using Casino;
using Casino.Blackjack;
using System.Data.SqlClient;
using System.Data;

namespace Blackjack
{
    class Program
    {
        private static object sqlDbType;

        static void Main(string[] args)
        {
            //string text = "Here is some text."; //Utilizing File I/O to write text to a document (below).
            ////(Below) Writing text to a file. Because we used the @ symbol at the beginning, we dont have to use double \\ because it's inside a string.
            ////The @ symbol means to 'read literally'.
            //File.WriteAllText(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt", text);

            ////Here we are writing text to a file.
            //File.ReadAllText(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt");

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45); //DateTime Method. (Year, Month, Day, Hour, Minute, Second).
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22); //DateTime Method. (Year, Month, Day, Hour, Minute, Second).
            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            const string casinoName = "Grand Hotel and Casino";

            Guid identifier = Guid.NewGuid();

            Console.WriteLine("Welcome to Blackjack Table!");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin");
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

                Console.WriteLine(); //Line Break.

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer) //While validAnswer IS FALSE.
            {
                Console.WriteLine("And how much money did you bring today?"); //Prints string.
                validAnswer = Int32.TryParse(Console.ReadLine(), out bank); //TryParse is assinging a value to a result (which here, is 'bank') and sending back to 'bank' 4 lines above.
                if (!validAnswer) //Saying if NOT validAnswer.
                {
                    Console.WriteLine(); //Line Break.
                    Console.WriteLine("Please enter digits only, no decimals."); //Prints string.
                }
            }

                Console.WriteLine(); //Line Break.

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower(); //.ToLower() makes users entry lowercase, making the process easier.

                Console.WriteLine(); //Line Break.

            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();

                using (StreamWriter file = new StreamWriter(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt", true))
                {
                    file.WriteLine(player.Id); //Records GUID to document (above).
                }

                Game game = new BlackjackGame();
                game += player; //Adding a 'player' to the 'game'.
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) //While player is playing and balance is more than zero.
                {
                    try
                    {
                        game.Play(); //Continues game.
                    }
                    catch (FraudException ex) //Catching FraudException.
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex); //Updates database with exception details.
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex) //Catching exceptions.
                    {
                        Console.WriteLine("Nice try, {0}! You can do better than that!", player.Name); //Prints string and value.
                        UpdateDbWithException(ex); //Updates database with exception details.
                        Console.WriteLine(); //Line Break.
                        Console.ReadLine();
                    }
                }
                game -= player;

                    Console.WriteLine(); //Line Break.

                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around! Goodbye.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            //The string below was found by right-clicking on Blackjack DC, Properties, then in the Property Window, copy/paste Connection String.
            //To eliminate the Escape Character error, put an @ symbol infront of the string (seen below).
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackjackGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                  (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackjackGame;Integrated Security=True;Connect Timeout=30;
                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
