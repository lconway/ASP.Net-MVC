using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtRaces
{
    public class Bet
    {
        public int Amount;  // The amount of cash that was bet
        public int Dog;     // The number of the dog the bet is on
        public Guy Bettor;  // The guy who placed the bet

        // Return a string that says who placed the bet,  how much
        // cash was bet, and which dog he bet on ("Joe bet 8 bucks on dog #4")
        // If the amount was 0, no bet was placed ("Joe hasn't placed a bet")
        public string GetDescription()
        {
            if (Amount == 0)
            {
                return Bettor.Name + " hasn't placed a bet";
            }
            else
            {
                return Bettor.Name + " bets " + Amount + " bucks on dog #" + Dog;
            }
        }

        // The parameter is the winner of the race.  If the dog won,
        // return the amount bet.  Otherwise return the negative of
        // the amount bet.
        public int PayOut(int Winner)
        {
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
