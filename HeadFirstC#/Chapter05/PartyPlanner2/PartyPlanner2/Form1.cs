using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    public partial class Form1 : Form
    {
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            birthdayParty = new BirthdayParty((int)numberBirthday.Value,
                fancyBirthdayBox.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthdayBox_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthdayBox.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }


        private void numberOfPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void costLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
