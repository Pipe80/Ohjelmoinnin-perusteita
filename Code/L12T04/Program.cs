using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12T04
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> jumpAround = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Give me a grade for the jump?");
                jumpAround.Add(int.Parse(Console.ReadLine()));
            }
            
            jumpAround.Sort();            
            jumpAround.RemoveAt(0);
            jumpAround.RemoveAt(3);

            int average;
            int thoseTogether=0;

            foreach (int list in jumpAround)
            {
               thoseTogether += list;             
            }
            average=thoseTogether/jumpAround.Count;
            Console.WriteLine("All together it is: " + thoseTogether);
            Console.WriteLine("Average is: "+average);
            Console.ReadKey();

                //Tehtävä L12T04(2 pistettä)
                //Mäkihypyssä käytetään viittä arvostelutuomaria.
                //Kirjoita ohjelma joka kysyy arvostelupisteet yhdelle hypylle.
                //Tulosta tyylipisteiden summa ja keskiarvo siten, että pisteistä on vähennetty pois pienin ja suurin tyylipiste.
            
        }
    }
}


