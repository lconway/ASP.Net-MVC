﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numberOfPeopleUpDown.Value,
                fancyBox.Checked, healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void numberOfPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }
    }
}
