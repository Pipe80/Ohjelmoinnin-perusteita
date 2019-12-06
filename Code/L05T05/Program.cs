using System;

namespace L05T05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä L05T05(2 pistettä)
            //Esittele muuttuja johon tallennetaan pankkitilin saldo euroina.
            //Kysy konsolissa kuinka monta euroa lisätään saldoon.
            //Kysy konsolissa kuinka monta senttiä lisätään saldoon.
            //Tulosta saldo konsoliin näiden muutosten jälkeen.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            decimal balance = 1200.40M;
            decimal euro;
            decimal amount;


            Console.WriteLine("How much money you want to deposit in euros? ");
            euro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cents do you want to add? ");
            amount = Convert.ToInt32(Console.ReadLine());
            decimal remainder = amount / 100;
            decimal income = balance + euro + remainder;
            Console.WriteLine("Balance after that is: " + income + "€");
            Console.ReadKey();
        }
    }
}

