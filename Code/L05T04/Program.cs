using System;

namespace L05T04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma joka kysyy käyttäjältä kaksi kokonaislukua ja tulostaa niiden:
            //Summan
            //Erotuksen
            //Tulon
            //Jakolaskun tuloksen
            int num01;
            int num02;
            Console.WriteLine("Give me a integer? ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a integer? ");
            num02 = Convert.ToInt32(Console.ReadLine());
            int num03 = num01 + num02;
            int num04 = num01 - num02;
            int num05 = num01 * num02;
            int num06 = num01 / num02;
            Console.WriteLine("Adds numbers together: "+num03+", Minus: "+num04+", Income: "+num05+", Division: "+num06);
            Console.ReadKey();
        }
    }
}
