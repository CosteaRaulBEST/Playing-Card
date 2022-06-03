using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using playing_card.Cards;

namespace playing_card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck.FillDeck();
         //   Deck.PrintDeck();
            Deck.Shuffle();
            Deck.PrintDeck();
            Console.ReadLine();
        }
    }
}
