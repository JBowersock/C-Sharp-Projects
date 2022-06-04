﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Card //(Note: Made public for access).
    {
        public Suit Suit { get; set; } //Saying has a property (public), data type (string) and name (Suit). Then you can 'get' or 'set' the property.
        public Face Face { get; set; } //Saying has a property (public), data type (string) and name (Face). Then you can 'get' or 'set' the property.
    }
    public enum Suit
    {
        Clubs = 4,
        Diamonds = 10,
        Hearts = 12,
        Spades = 15
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
