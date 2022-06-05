using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Added to class.

namespace Blackjack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //.First is a method available to a List, that takes the very first item in that List.
            //.RemoveAt is a method available to a List, that where you pass in an index of where you want to remove (in the example below, it is '0'.)
            Hand.Add(Deck.Cards.First()); //Adding first card in deck to hand.
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); //Prints to screen which card was dealt.
            //(Below) Here we're writing some of the data from a game played within a file on the PC. Recording what happened. True (at the end) tells the program to append some text to the file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\Streaming Desktop\Desktop\The Tech Academy - Software Development Program\C-Sharp-Projects\fileIOPartOneVideo.txt", true))
            {
                file.WriteLine(DateTime.Now); //Records Date/Time to file after a game is played. (above).
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //Removing from list at 0.
        }
    }
}
