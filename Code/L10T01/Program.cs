using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10T01
{
    class Program
    {

        private static void CheckEfficiency(ref Vehicle details)
        {
            if (details.ModelYear <= 1990)
            {
                details.Effiency = 10;
            }

            else if (details.ModelYear >= 1991 && details.ModelYear <= 2010)
            {
                details.Effiency = 50;
            }
            else
            {
                details.Effiency = 100;
            }
        }

        struct Vehicle
        {
            public string Name;
            public int ModelYear;
            public int Effiency;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the model year? ");
            int year = int.Parse(Console.ReadLine());

            Vehicle car = new Vehicle();
            car.Name = "Mazda 6";
            car.ModelYear = year;
            CheckEfficiency(ref car);
            Console.WriteLine("Year: "+car.ModelYear+" Name: "+car.Name+" Effiency: "+car.Effiency);
            Console.ReadKey();

        }
        //Tehtävä L10T01(5 pistettä)
        //Tee Vehicle-niminen tietue ja lisää sille jäseniksi ainakin Name, ModelYear ja Efficiency.
        //Luo ajoneuvo ja aseta sille ominaisuudet.
        //Tee Program luokkaan CheckEfficiency metodi jonne void lähettää Vehicle tyyppisen muuttujan parametrina.
        //CheckEfficiency asettaa ajoneuvon Efficiency arvon seuraavasti:

        //jos ModelYear on pienempi kuin 1990 Efficiency asetetaan arvoon 10
        //muuten jos ModelYear on pienempi kuin 2010 Efficiency asetetaan arvoon 50
        //muissa tapauksissa Efficiency asetetaan arvoon 100
        //Kutsu CheckEfficiency metodia niin että se muuttaa parametrina lähetetyn ajoneuvon Efficiency ominaisuutta.
    }
}


