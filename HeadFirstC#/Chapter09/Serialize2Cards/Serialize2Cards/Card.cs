using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize2Cards
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    public enum Values
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    [Serializable]
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public string Name {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
    }
}
