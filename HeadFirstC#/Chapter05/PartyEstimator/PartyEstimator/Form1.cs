using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyEstimator
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyOptionCheckBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void healthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyOptionCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyDecorationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyDecorationsCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void numberOfPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleUpDown.Value;
            dinnerParty.CalculateCostOfDecorations(fancyDecorationsCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
