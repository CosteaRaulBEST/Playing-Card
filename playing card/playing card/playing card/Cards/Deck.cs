using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using playing_card.Cards;

namespace playing_card.Cards
{
     class Deck
    {
        public static Card[] deck = new Card[52];

        public static void FillDeck()
        {
            int index = 0;
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                for (int value = 2; value <= 14; value++)
                {
                    Card card = new Card(value, suit);
                    deck[index] = card;
                    index++;
                }
            }
        }
        public static void PrintDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }
        public static void swap(int a, int b)
        {
            Card aux = deck[a];
            deck[a] = deck[b];
            deck[b] = aux;
        }
        public static void Shuffle()
        {

            Random random = new Random();
            int j;
            for (int i = deck.Length - 1; i >= 0; i--)
            {
                j = random.Next(0, i);
                swap(i, j);
            }
        }
        public static Card randomCard()
        {
            Random random = new Random();
            return deck[random.Next(deck.Length)];
        }
    }
}
