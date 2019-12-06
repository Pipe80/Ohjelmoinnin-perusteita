using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10T01
{
    class Program
    {

        public static void Init(int num,out int param1, out int param2, out int param3, out int param4, out int param5)
        {
            param1 = num * 2;
            param2 = num * 10;
            param3 = num * 100;
            param4 = num * 1000;
            param5 = num * 10000;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("What is the number(integer)? ");
            int num = int.Parse(Console.ReadLine());

            Init(num,out int first,out int second,out int third,out int fourth,out int fift);

            Console.WriteLine(" " + first+" " +second+ " "+third+" "+fourth+" "+fift);
            Console.ReadKey();

        }
//Tehtävä L10T02(5 pistettä)
//Tee metodi nimeltä Init jolle annetaan parametrina kokonaisluku ja joka alustaa 5 muuta 
//parametria seuraavalla tavalla.
//param1 = num* 2;
//param2 = num* 10;
//param3 = num* 100;
//param4 = num* 1000;
//param5 = num* 10000;

//Kutsu Init metodia niin että se muokkaa sille paramerina annettavia muuttujia.
    }
}