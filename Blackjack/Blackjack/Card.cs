using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card //adding 'public' here let's the Program.cs file access this one.
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //Saying has a property (public), data type (string) and name (Suit). Then you can 'get' or 'set' the property.
        public string Face { get; set; } //Saying has a property (public), data type (string) and name (Face). Then you can 'get' or 'set' the property.
    }
}
