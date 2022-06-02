using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //Instanitated an object called deck and assigned it to the variable;
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); //Shuffles deck. //Note: This method shuffles the deck once.

            foreach (Card card in deck.Cards) //For Loop
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //Prints string.
            }
            Console.WriteLine(); //Line Break.
            Console.WriteLine("Total Cards: " + deck.Cards.Count); //Prints total amount of cards in deck. (Result: 52).
            Console.WriteLine("Times Shuffled: " + timesShuffled);
            Console.ReadLine(); //Allows window to remain open until user closes.
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //'int times = 1' means the
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0) //While Loop
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
