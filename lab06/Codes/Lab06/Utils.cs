using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Utils
    {
        public static void PrintInfo()
        {
            //Tehtävä L06T01(2 pistettä)
            //Ohjelmoi luokka nimeltä Utils. Tee se omaan Utils.cs tiedostoon.
            //Lisää Utils luokalle metodi Info ja tulosta sen sisällä konsoliin teksti "Utils.Info".
            //Kutsu Utils.Info metodia ja varmista että tulostus näkyy konsolissa.
            Console.WriteLine("Utils.Info");
        }
        public static int Subtract(int num01,int num02)
        //Tehtävä L06T02(2 pistettä)
        //Lisää Utils luokalle metodi Subtract jolle viedään 2 parametria.
        //Subtract metodi palauttaa annettujen parametrien erotuksen.
        //Kutsu Utils.Subtract metodia ja tulosta sen palauttama arvo konsoliin.
        {
            int num03 = num01 - num02;

            Console.WriteLine("1.Number - 2.Number = "+num03);
            return num03;
        }
        public static float Average(float number01, float number02, float number03)
        //Tehtävä L06T03(2 pistettä)
        //Lisää Utils luokalle metodi Average jolle viedään 3 parametria.
        //Average metodi palauttaa annettujen parametrien keskiarvon.
        //Kutsu Utils.Average metodia ja tulosta sen palauttama arvo konsoliin.
        {
            float numberaverage = number01 + number02 + number03;
            Console.WriteLine("Average is: " + numberaverage / 3);
            return numberaverage;
        }
        public static void CalcConsumption(double liter, double price, double km)
        {
            double tc = liter / 100 * km;
            Console.WriteLine("Gas you have used:" + tc);
            Console.WriteLine("Gasoline price:" + price * tc);
            
        }
 
        //Tehtävä L06T04(4 pistettä)
        //Lisää Utils luokalle metodi CalcConsumption.Sinne viedään parametreina:
        //auton kulutus litraa/100km
        //polttoaineen hinta euroa per litra
        //kuljettu matka kilometreinä.
        //CalcConsumption metodi tulostaa konsoliin kuinka monta litraa polttoainetta on kulunut matkalla, 
        //sekä polttoaineeseen kuluneen rahan määrän.
        //Kysy käyttäjältä kulutus, polttoaineen hinta ja kuljettu matka.
        //Kutsu Utils.CalcConsumption metodia että näet tulokset.
    }
}
