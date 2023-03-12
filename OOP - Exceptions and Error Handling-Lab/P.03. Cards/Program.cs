using System;
using System.Collections.Generic;
using System.Linq;

namespace P._03._Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string pair in input)
            {
                string[] info = pair
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string face = info[0];
                string suit = info[1];

                try
                {
                    Card currCard = new Card(face, suit);
                    cards.Add(currCard);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(string.Join(" ", cards));
        }
    }

    class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get
            {
                return face;
            }
            private set
            {
                List<string> validFaces = new List<string>()
                { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

                if (!validFaces.Contains(value))
                {
                    throw new Exception("Invalid card!");
                }

                face = value;
            }
        }

        public string Suit
        {
            get
            {
                return suit;
            }
            private set
            {
                List<string> validSuits = new List<string>() { "S", "H", "D", "C" };
                if (!validSuits.Contains(value))
                {
                    throw new Exception("Invalid card!");
                }

                suit = value;
            }
        }


        public override string ToString()
        {
            string symbol = string.Empty;
            switch (Suit)
            {
                case "S":
                    symbol = '\u2660'.ToString();
                    break;
                case "H":
                    symbol = '\u2665'.ToString();
                    break;
                case "D":
                    symbol = '\u2666'.ToString();
                    break;
                case "C":
                    symbol = '\u2663'.ToString();
                    break;
            }

            return $"[{Face}{symbol}]";
        }
    }
}
