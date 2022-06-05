using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Blackjack
{
    public class BlackjackRules //Public Class.
    {
        //Notes:
        //Private means only to be used within the class.
        //We're utilizing a Dictionary.
        //A naming convention within private classes is to use an underscore ahead of it (such as below).
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //Adding seperate values to cards.
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        }; //Semicolon required here.

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //Assigning using a Lambda Expression.
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value = value + (i * 10); //To shorten this, you could do 'value += (i * 10);'.
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackjack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); //Integer Array
            int value = possibleValues.Max();
            if (value == 21) return true; //Single line If Statement.
            else return false; //Single line Else Statement.
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); //Lambda Expression.
            if (value > 21) return true; //Single line If Statement.
            else return false; //Single line Else Statement.
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); //Saying: find the highest value that is less than 22 (to determine winner between player and dealer).
            int dealerScore = dealerResults.Where(x => x < 22).Max(); //Saying: find the highest value that is less than 22 (to determine winner between player and dealer).

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
