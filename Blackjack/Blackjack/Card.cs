using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card //(Note: Made public for access).
    {
        public Card() //(Note: Made public for access).
        {
            Suit = "Spades"; //A property of 'Card'.
            Face = "Two"; //A property of 'Card'.
        }
        public string Suit { get; set; } //Saying has a property (public), data type (string) and name (Suit). Then you can 'get' or 'set' the property.
        public string Face { get; set; } //Saying has a property (public), data type (string) and name (Face). Then you can 'get' or 'set' the property.
    }
}
