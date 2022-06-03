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
            deck.Shuffle();

            foreach (Card card in deck.Cards) //For Loop
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //Prints string.
            }
            Console.WriteLine(); //Line Break.
            Console.WriteLine("Total Cards: " + deck.Cards.Count); //Prints total amount of cards in deck. (Result: 52).
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
