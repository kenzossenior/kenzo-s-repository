using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            Console.WriteLine("DEAL 7 CARDS:");
            cards.OutputCards(7);

            Console.WriteLine("Cut the deck, then deal 7 more cards ");
            cards.CutDeck();
            cards.OutputCards(7);

            Console.WriteLine("Shuffle the deck, then deal a further 7 cards");
            cards.Shuffle();
            cards.OutputCards(7);

            Console.ReadKey();
            
        }
    }
}
