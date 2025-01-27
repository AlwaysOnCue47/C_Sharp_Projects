using System;
using System.Collections.Generic;

namespace Mod2Assignment3 // Twenty-One game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
           
        }
    }
}
