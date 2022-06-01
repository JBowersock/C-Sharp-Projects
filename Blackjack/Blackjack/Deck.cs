using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck //adding 'public' here let's the Program.cs file access this one.
    {
        public Deck()
        {
            //Constructor. A method that is called as soon as an object is created. The first thing it does is instantiates its property (Cards) as an empty list of Cards.
            //The Constructor creates the lists, and immediatly instantiates them with values.
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //This list gives value to the suits of the cards in the deck.
            List<string> Faces = new List<string>() //This list gives value to each of the faces of the cards in the deck.
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
