using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue people = new Queue();
            people.Enqueue("Customer 1: Donald");
            people.Enqueue("Customer 2: Leonard");
            people.Enqueue("Customer 3: Enya");
            people.Enqueue("Customer 4: Ron");

            foreach (Object item in people)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("The number of people int the line: " + people.Count);
            Console.ReadKey();
        }
    }
}
// Tehtävä L13T03(2 pistettä)
//Toteuta ratkaisu joka simuloi kaupan kassalla olevaa asiakasvirtaa.
//Käytä ratkaisussa Queue kokoelmaa.


