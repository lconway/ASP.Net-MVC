using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtRaces
{
    public class Guy
    {
        public string Name; // Guy's name
        public Bet MyBet;   // Instance of Bet guy has
        public int Cash;    // How much cash he has

        public RadioButton MyRadioButton;
        public Label MyLabel;

        // Set my label to my bet's description, and the label on my
        // radio button to show my cash ("Joe has 43 bucks")
        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyLabel.Text = Name + " hasn't placed a bet";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        // Reset my bet so it is 0
        public void ClearBet()
        {
            MyBet = null;
        }

        // Place a new bet and store it in my guy's field
        // Return true if the guy had enough money to bet
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet()
            {
                Bettor = this,
                Amount = BetAmount,
                Dog = DogToWin
            };

            if (Cash > BetAmount)
            {
                MyLabel.Text = MyBet.GetDescription();
                return true;
            }
            else
                return false;
        }

        // Ask my bet to payout, clear my bet and update my labels
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
