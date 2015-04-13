using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flapjacks
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine;

        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            string newItem = "";
            int i = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                newItem = i + ". " + lumberjack.Name;
                line.Items.Add(newItem);
                i++;
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;

            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            lumberjacksFlapjacks.Text = currentLumberjack.Name + " has " + 
                currentLumberjack.FlapjackCount + " flapjacks";

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Dequeue();
            lumberjacksFlapjacks.Text = "";
            RedrawList();
        }
    }
}
