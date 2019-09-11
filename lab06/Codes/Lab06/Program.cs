using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {         
            static void Main(string[] args)
            {
            //Tehtävä L06T01
            Utils.PrintInfo();
            Console.ReadKey();
            //Tehtävä L06T02
            Console.WriteLine("Add 1.Number?");
            int num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minus 2.Number?");
            int num02 = int.Parse(Console.ReadLine());
            int num03 = Utils.Subtract(num01,num02);
            Console.ReadKey();

            //Tehtävä L06T03
            Console.WriteLine("Add 1.Number?");
            float number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add 2.Number?");
            float number02 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add 3.Number?");
            float number03 = int.Parse(Console.ReadLine());
            float numberaverage = Utils.Average(number01,number02,number03);
            Console.ReadKey();

            //Tehtävä L06T04
            Console.WriteLine("Car consumption/100km?");
            double liter = double.Parse(Console.ReadLine());
            Console.WriteLine("Price of fuel/one liter?");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Distance to destination?");
            double km= double.Parse(Console.ReadLine());
            Utils.CalcConsumption(liter,price,km);
            Console.ReadKey();
        }
    }
    }
