using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12T05
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int >randomList= new List<int>();

            Random number = new Random();

            for (int i = 0; i <10; i++)
            {
                randomList.Add(number.Next(0, 100000));

            }
            randomList.Sort();
            randomList.Reverse();
            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
            
            
//Tehtävä L12T05(2 pistettä)
//Tee taulukko jossa on 10 satunnaista kokonaislukua.
//Järjestä taulukko suurimmasta pienimpään.
//Tulosta taulukon sisältö konsoliin.
        }
    }
}
