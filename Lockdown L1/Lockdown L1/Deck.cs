using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockdown_L1
{
    class Deck
    {
        public int NumberOfCards
        {
            get
            {
                return cards.Count;
            }
        }
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            for (int i = 0; i < 52; i++)
            {
                cards.Add(new Card(values[i % 4], suits[i / 13]));
            }
        }
        //Methods

        public void OutputCards(int num)
        {
            for (int i = 0; i < num - 1; i++)
            {
                Console.WriteLine(Deal(i).GetDescription());
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < NumberOfCards; i++)
            {
                int NewLocation = rnd.Next(i + 1);
                Card tempCard = cards[i];
                cards[i] = cards[NewLocation];
                cards[NewLocation] = tempCard;
            }
        }

        public Card Deal(int location)
        {
            return cards[location];
        }

        public void AddCard(Card tempCard)
        {
            cards.Add(tempCard);
        }

        public void CutDeck()
        {
            int newLocation = NumberOfCards / 2;
            for (int i = 0; i < NumberOfCards/2; i++)
            {
                Card tempCard = cards[i];
                cards[i] = cards[newLocation];
                cards[newLocation] = tempCard;
                newLocation++;
            }
        }
    }

    class Card
    {
        private string Suit;
        private string Value;


        public Card(string cardValue, string cardSuit)
        {
            Value = cardValue;
            Suit = cardSuit;
        }

        private string GetFace()
        {
            if (Suit == "Hearts" || Suit == "Diamonds")
            {
                return "Red";
            }
            else
            {
                return "Black";
            }
        }

        public string GetDescription()
        {
            return $"{Value} of {GetFace()} {Suit}";
        }
    }
}
