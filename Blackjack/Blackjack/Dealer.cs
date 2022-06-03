using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //Prints to screen which card was dealt.
            Deck.Cards.RemoveAt(0); //Removing from list at 0.
        }
    }
}
