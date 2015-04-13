using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoCardDecks
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                List<Card> cards = new List<Card>();
                int numberOfCards = random.Next(1, 10);
                for (int i = 0; i < numberOfCards; i++)
                    cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 13)));
                deck1 = new Deck(cards);
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                deck1List.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    deck1List.Items.Add(cardName);
                deck1Label.Text = "Deck #1 (" + deck1List.Items.Count + ")";
            }
            else
            {
                deck2List.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    deck2List.Items.Add(cardName);
                deck2Label.Text = "Deck #1 (" + deck2List.Items.Count + ")";
            }
        }

        private void toDeck2_Click(object sender, EventArgs e)
        {
            if (deck1List.SelectedIndex >= 0)
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(deck1List.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void toDeck1_Click(object sender, EventArgs e)
        {
            if (deck2List.SelectedIndex >= 0)
                if (deck2.Count > 0)
                    deck1.Add(deck2.Deal(deck2List.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }
    }
}
