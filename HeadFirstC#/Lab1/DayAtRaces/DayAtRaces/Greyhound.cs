using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        // Move forward either 1, 2, 3 or 4 spaces at random
        // Update the position of my PictureBox on the form
        // Return true if I won the race.
        public bool Run()
        {
            Location += Randomizer.Next(4);
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength)
                return true;
            else
                return false;
        }

        // Reset my location to 0 and my PictureBox to starting position
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
