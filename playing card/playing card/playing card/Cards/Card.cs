using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playing_card.Cards
{
    enum Suits
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades

    }
    class Card
    {
        public int Value;
        public  Suits Suit;

        public Card(int value, Suits suit)
        {
            Value = value;
            Suit = suit;

        }
        public override string ToString()
        {
            switch(Value)
            {
                case 11:
                    {
                        return  "Jack of " + Suit;

                    }
                case 12:
                    {
                        return "Queen of " + Suit;

                    }
                case 13:
                    {
                        return "King of " + Suit;

                    }
                case 14:
                    {
                        return "Ace of " + Suit;

                    }
                default:
                    {
                        return $"{Value} of " + Suit;
                    }
            }
        }

    }
    

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

        public static void swap ( int a , int b)
        {
            Card aux = deck[a];
            deck[a] = deck[b];  
            deck[b] = aux;
        }
        public static void Shuffle()
        {
            Random random = new Random();
            int j;
            for ( int  i = deck.Length - 1; i >= 0; i--)
            {
               j = random.Next(0,i);    
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