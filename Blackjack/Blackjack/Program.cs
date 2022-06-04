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
            

            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            //Deck deck = new Deck(); //Instanitated an object called deck and assigned it to the variable;
            //deck.Shuffle(3); //Shuffles deck 3x.

            //foreach (Card card in deck.Cards) //For Loop
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit); //Prints string.
            //}
            //Console.WriteLine("Total Cards: " + deck.Cards.Count); //Prints total amount of cards in deck. (Result: 52).
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
