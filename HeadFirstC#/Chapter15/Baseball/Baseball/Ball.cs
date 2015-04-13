using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball {
    class Ball {

        // ball has a BallInPlay event
        public event EventHandler<BallEventArgs> BallInPlay;

        // raise the BallInPlay event
        protected void OnBallInPlay(BallEventArgs e) {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if (ballInPlay != null)
                // event is now active
                ballInPlay(this, e);
        }

        public Bat GetNewBat() {
            // create a new Bat object whos constructor expects a BatCallBack delegate
            return new Bat(new BatCallback(OnBallInPlay));
        }
    }

    class BallEventArgs : EventArgs {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs(int trajectory, int distance) {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
}
