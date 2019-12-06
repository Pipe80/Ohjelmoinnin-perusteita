using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13T01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> suit = new List<string>() { "Hearts", "Spades" , "Clubs", "Diamonds"};
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10/*,11,12,13*/};
            List<string> numbersToo = new List<string>() { "J", "Q", "K", "A" };

            foreach (var item in numbers)
            {
                Console.Write(suit[0] + " " +item+" ");
                Console.Write(suit[1] + " " + item + " ");
                Console.Write(suit[2] + " " + item + " ");
                Console.Write(suit[3] + " " + item + " ");
                Console.WriteLine();
            }
            foreach (var item in numbersToo)
            {
                Console.Write(suit[0] + " " + item + " ");
                Console.Write(suit[1] + " " + item + " ");
                Console.Write(suit[2] + " " + item + " ");
                Console.Write(suit[3] + " " + item + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
            //Tehtävä L13T01(2 pistettä)
            //Toteuta ohjelma joka tallentaa kaikki korttipelin kortit(hertta, ruutu, risti ja pata.Numerot 1 - 52.) valitsemaasi tietorakenteeseen
            //Tulosta korttipakka konsoliin.
        }
    }
}
