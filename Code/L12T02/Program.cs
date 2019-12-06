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
           int sum= size+10;
            int[] numbers = new int[size];
            Console.WriteLine(sum);
            Console.Clear();

            Array.Reverse(numbers);

            for (int i = size; i >0; i--)
            {
                Console.WriteLine(sum--);
            }
    
            Console.ReadKey();

//Tehtävä L12T02(2 pistettä)
//Sama kuin tehtävä L11.01, mutta tulosta taulukon sisältö takaperin - eli viimeinen alkio ensin.
        }
    }
}
