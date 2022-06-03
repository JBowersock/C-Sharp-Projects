using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class BlackjackGame : Game //Made public, then Inhereting from another class. (which is 'Game').
    {
        //In order for the method below to run, it must have an Override for the Abstract method (seen in Game.cs).
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to Blackjack!");
            base.ListPlayers();
        }
    }
}
