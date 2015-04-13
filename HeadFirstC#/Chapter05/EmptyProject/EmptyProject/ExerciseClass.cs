using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject
{
    class ExerciseClass
    {
        class Boat
        {
            private int length;
            public void setLength(int len)
            {
                length = len;
            }
            public int getLength() {
                return length;
            }
            public virtual string move() {
                return "drift";
            }
        }

        class RowBoat : Boat
        {
            public string rowTheBoat()
            {
                return "stroke natasha";
            }
        }
        class SailBoat : Boat
        {
            public override string move()
            {
                return "hoist sail";
            }
        }

        public static void Main()
        {
            string xyz = "";
            Boat b1 = new Boat();
            SailBoat b2 = new SailBoat();
            RowBoat b3 = new RowBoat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }

    }
}
