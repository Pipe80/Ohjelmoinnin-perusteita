using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12T03
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[ ] {1,2,33,44,55,68,77,96,100};

            foreach (var answer in numbers)
            {
                if (answer % 2==0)
                {
                    Console.WriteLine("EVEN");
                }
                else
                {
                    Console.WriteLine("---");
                }
                Console.ReadKey();
            }
//Tehtävä L12T03(2 pistettä)
//Tee ohjelma joka alustaa sovellukseen käyttöön seuraavan taulukon arvot
//1,2,33,44,55,68,77,96,100
//Käy sovelluksessa taulukko läpi ja tulosta konsoliin "EVEN" - sana aina kun taulukossa oleva luku on parillinen.
        }
    }
}
