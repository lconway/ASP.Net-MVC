using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize2Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(Suits.Clubs, Values.Three);
            Card card2 = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("three-c.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, card1);
            }

            using (Stream output = File.Create("six-h.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, card2);
            }

            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Byte {0}: {1} versus {2}",
                        i, firstFile[i], secondFile[i]);

            firstFile[272] = (byte)Suits.Spades;
            firstFile[322] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            Card newCard;
            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                newCard = (Card)formatter.Deserialize(input);
            }

            Console.WriteLine("New card is {0} of {1}", newCard.Value, newCard.Suit);
            Console.ReadKey();
        }
    }
}
