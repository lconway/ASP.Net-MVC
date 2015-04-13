using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtRaces
{
    public partial class Form1 : Form
    {
        public Greyhound[] greyhounds = new Greyhound[4];
        public Guy[] guys = new Guy[3];
        public Random MyRandomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            // Initialize greyhounds
            greyhounds[0] = new Greyhound()
            {
                MyPictureBox = dogPicture1,
                StartingPosition = dogPicture1.Left,
                RaceTrackLength = racetrackPicture.Width - dogPicture1.Width,
                Randomizer = MyRandomizer
            };

            greyhounds[1] = new Greyhound()
            {
                MyPictureBox = dogPicture2,
                StartingPosition = dogPicture2.Left,
                RaceTrackLength = racetrackPicture.Width - dogPicture2.Width,
                Randomizer = MyRandomizer
            };

            greyhounds[2] = new Greyhound()
            {
                MyPictureBox = dogPicture3,
                StartingPosition = dogPicture3.Left,
                RaceTrackLength = racetrackPicture.Width - dogPicture3.Width,
                Randomizer = MyRandomizer
            };

            greyhounds[3] = new Greyhound()
            {
                MyPictureBox = dogPicture4,
                StartingPosition = dogPicture4.Left,
                RaceTrackLength = racetrackPicture.Width - dogPicture4.Width,
                Randomizer = MyRandomizer
            };

            // Initialize guys
            guys[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };
            guys[0].UpdateLabels();

            guys[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };
            guys[1].UpdateLabels();

            guys[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };
            guys[2].UpdateLabels();

            // Initialize minimum bet label
            minimumBetLabel.Text = "Minimum bet: " + betUpDown.Minimum + " bucks";
        }

        // Joe is placing a bet
        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        // Bob is placing a bet
        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        // Al is placing a bet
        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        // Place bet on the guy whose radio button is checked
        private void betsButton_Click(object sender, EventArgs e)
        {
            if (guys[0].MyRadioButton.Checked)
                guys[0].PlaceBet((int)betUpDown.Value, (int)dogUpDown.Value);
            else if (guys[1].MyRadioButton.Checked)
                guys[1].PlaceBet((int)betUpDown.Value, (int)dogUpDown.Value);
            else
                guys[2].PlaceBet((int)betUpDown.Value, (int)dogUpDown.Value);
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            resetButton.Enabled = false;
            // Start race
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < greyhounds.Length; i++)
            {
                if (greyhounds[i].Run())
                {
                    // We have a winner;  Stop race
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i+1) + " won the race!", "We have a winner");
                    for (int j = 0; j < guys.Length; j++)
                    {
                        // Each guy collects his winnings or his losses
                        guys[j].Collect(i+1);
                    }
                    resetButton.Enabled = true;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < greyhounds.Length; i++)
            {
                greyhounds[i].MyPictureBox.Left = greyhounds[i].StartingPosition;
            }

        }
    }
}
