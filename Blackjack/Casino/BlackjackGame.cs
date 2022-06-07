using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Blackjack
{
    public class BlackjackGame : Game, IWalkAway //Made public, then Inhereting from another class. (which is 'Game').
    {
        public BlackjackDealer Dealer { get; set; }

        //In order for the method below to run, it must have an Override for the Abstract method (seen in Game.cs).
        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer) //While validAnswer IS FALSE.
                {
                    Console.WriteLine("Place your bet!"); //Prints string.
                    validAnswer = Int32.TryParse(Console.ReadLine(), out bet); //TryParse is assinging a value to a result (which here, is 'bank') and sending back to 'bank' 4 lines above.
                    if (!validAnswer) //Saying if NOT validAnswer.
                    {
                        Console.WriteLine(); //Line Break.
                        Console.WriteLine("Please enter digits only, no decimals."); //Prints string.
                    }
                }
                if (bet < 0)
                {
                    Console.WriteLine(); //Line Break.
                    throw new FraudException("Security! Kick this person out!"); //Throws FraudException.
                }

                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //Note: This being in a void method, we're not actually returning anything. We're just saying "end this method".
                }
                Bets[player] = bet;
            }

                Console.WriteLine(); //Line Break.

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackjackRules.CheckForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //It's 1.5 because apparently in Blackjack.. that's what it is. Idk.
                            Bets.Remove(player); //Removing player from table.
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackjackRules.CheckForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay) //While player is NOT staying.
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString()); //Shows the player their cards.
                    }
                    Console.WriteLine("\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);

                            Console.WriteLine(); //Line Break.

                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah") //If answer is equal to this OR that.
                        {
                            player.isActivelyPlaying = true;
                            return; //Ends function.
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return; //Ends function.
                        }
                        Console.WriteLine(); //Line Break.
                    }
                }
            }

                Console.WriteLine(); //Line Break.

            Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand); //Checking if Dealer is busted.
            Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) //While Dealer is NOT stay or busted.
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackjackRules.IsBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted.");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //Note: Key is the player.
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //Lambda Expression. Here we are giving the money won to that players balance.
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = BlackjackRules.CompareHands(player.Hand, Dealer.Hand); //Note: 'bool?'. By adding the ? to the end of bool, it turns it into a nullable boolean. 
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                        Console.WriteLine(); //Line Break.

                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
                Console.WriteLine(); // Line Break.
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to Blackjack!");
            base.ListPlayers();
        }
        public void WalkAway(Player player) //This must be void in order to cooperate.
        {
            throw new NotImplementedException();
        }
    }
}
