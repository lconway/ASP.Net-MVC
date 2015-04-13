using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCards
{
    class Program
    {
        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
                Console.WriteLine(card.Value.ToString() + " of " + card.Suit.ToString());
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> cards = new List<Card>() {
                new Card((Suits)random.Next(4), (Values)random.Next(1, 13)),
                new Card((Suits)random.Next(4), (Values)random.Next(1, 13)),
                new Card((Suits)random.Next(4), (Values)random.Next(1, 13)),
                new Card((Suits)random.Next(4), (Values)random.Next(1, 13)),
                new Card((Suits)random.Next(4), (Values)random.Next(1, 13)),
            };

            CardComparer_byValue comparer = new CardComparer_byValue();

            Console.WriteLine("Five random cards:");
            PrintCards(cards);
            cards.Sort(comparer);
            Console.WriteLine();
            Console.WriteLine("Those same cards, sorted:");
            PrintCards(cards);

            Console.ReadKey();
        }
    }
}
