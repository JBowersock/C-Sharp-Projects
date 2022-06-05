using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck //(Note: Made public for access).
    {
        public Deck() //(Note: Made public for access).
        {
            //Constructor. A method that is called as soon as an object is created. The first thing it does is instantiates its property (Cards) as an empty list of Cards.
            //The Constructor creates the lists, and immediatly instantiates them with values.
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //This list gives value to the suits of the cards in the deck.
            //List<string> Faces = new List<string>() //This list gives value to each of the faces of the cards in the deck.
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            //foreach (string face in Faces) //ForEach Loop
            //{
            //    //foreach (string suit in Suits) //ForEach Loop
            //    //{
            //    //    Card card = new Card();
            //    //    card.Suit = suit;
            //    //    card.Face = face;
            //    //    Cards.Add(card);
            //    //}
            //}
        }
        public List<Card> Cards { get; set; } //Saying has a property (public). Lists from 'Cards' from 'Card'. Then you can 'get' or 'set' the property.

        public void Shuffle(int times = 1) //'int times = 1' means the
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0) //While Loop
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
