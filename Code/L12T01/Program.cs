using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12T01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers do you want to make?");
            int size = int.Parse(Console.ReadLine());
           
            int [] numbers=new int[size];
            Console.Clear();
            //Console.WriteLine("Taulun tulostus:");
            for (int i =0; i <numbers.Length; i++)
            {
                numbers[i] = i+10;
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
//Tehtävä L12T01(2 pistettä)
//Tee ohjelma joka kysyy käyttäjältä kuinka monta kokonaislukua luodaan.
//Luo oikea määrä kokonaislukuja taulukkoon.
//Alusta taulukon luvut niin että alkion arvo on alkion indeksi +10.
//Tulosta taulukon sisältö konsoliin.[]
        }
    }
}
