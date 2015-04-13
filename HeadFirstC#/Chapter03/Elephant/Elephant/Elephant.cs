using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public string name;
        public int earSize;

        public void WhoAmI()
        {
            MessageBox.Show("I am " + name + ".  My ear are size " + earSize + ".");
        }

    }

}
