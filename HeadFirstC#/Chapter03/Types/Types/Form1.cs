﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
           // bool myBool = (bool)myByte;
            string myString = "false";
           // myBool = (bool)myString;
           // myString = (string)myInt;
            myString = myInt.ToString();
           // myBool = (bool)myByte;
           // myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;
        }
    }
}
