using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playing_card.Cards
{
    enum Suits
    {
        Hearts ,
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
              
}