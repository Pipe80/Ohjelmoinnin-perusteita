using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L13T02
{
    class Program
    {
        public static List<T> Shuffle<T>(List<T> completeDeck)
        {
            Random mixing = new Random();
            for (int i = 0; i < completeDeck.Count; i++)
            {
                int k = mixing.Next(0, i);
                T value = completeDeck[k];
                completeDeck[k] = completeDeck[i];
                completeDeck[i] = value;
            }
            return completeDeck;
        }
        static void Main(string[] args)
        {
            List<string> completeDeck=CreateDeck();
            completeDeck=Shuffle(completeDeck);
            foreach (var item in completeDeck)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            //Tehtävä L13T02(2 pistettä)
            //Jatkoa edelliseen; Toteuta korttipakan sekoittaminen.
            //Toteuta Shuffle metodi joka sekoittaa pakan kortit satunnaiseen järjestykseen.
            //Kutsu Suffle metodia ja tulosta korttipakka konsoliin.
        }
        public static List<string> CreateDeck()
        {
            List <string> suit = new List<string>{ "Hearts", "Spades", "Clubs", "Diamonds" };
            //suit.Add("Joker");
            List <string> cards =new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List <string>suitAndCards = new List<string>(52);
            
            foreach (var item in suit)
            {
                foreach (var item2 in cards)
                {
                    suitAndCards.Add(item+ " "+item2);
                }
            }
            return suitAndCards;
        }
    }
}
