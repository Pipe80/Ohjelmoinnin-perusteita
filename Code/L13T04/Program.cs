
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13T04
{
    class Program
    {
        struct Movies
        {
            public string Movie2;
            public string Director2;
           public int Year2;
        }
        static Random mixing = new Random();
        static void Main()
        {//ajatuksena tehdä movies lista...jossa olisi sitten kaikki kolme eli title, year ja director.

            List<Movies> elokuvat = new List<Movies>();

            int vuosi = Year();
            int d = 0;
            foreach(var elokuva in elokuvat)
            {
                elokuvat[].Movie2;
                elokuvat[i].Director2;
                elokuvat[i].Year2;


            }  

         
            string[] alpha = new string[10];
            //[10]=[10000] helpottaa koodin pyörittämistä tässä vaiheessa!
            for (int i = 0; i < alpha.Length; i++)
            {
                alpha[i] = GenerateAlpha(10, mixing);
                //kutsuu GenerateCouponia, tekee siitä kirjainsotkusta 10-kirjainta pitkän ja randomia.
            }
            Console.WriteLine(String.Join(Environment.NewLine, alpha));

            string[] director = new string[10];
            //[10]=[10000] helpottaa koodin pyörittämistä tässä vaiheessa!

            for (int i = 0; i < director.Length; i++)
            {
                director[i] = Director(2, mixing);
                //kutsuu Directoria, tekee siitä kirjainsotkusta 2-kirjainta pitkän ja randomia.
            }
            Console.WriteLine(String.Join(Environment.NewLine,director));
            Console.ReadKey();
        }

       public static int Year()
        {
            int result = 0;
            for (int i = 0; i < 10; i++)
                //muista korjata 10=10 000!
            {
                result = mixing.Next(1880, 2020);
                Console.WriteLine("Year: " + result);                 
            }
            return result;
        }
        public static string GenerateAlpha(int length, Random random)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
        /// <summary>
        /// StringBuilder= Mutable strings of characters
        /// </summary>
        /// <param name="length"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        public static string Director(int length, Random random)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder answer = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                answer.Append(characters[random.Next(characters.Length)]);
            }
            return answer.ToString();
        }
    }
    }
 
//Tehtävä L13T04(4 pistettä)
//Toteuta ohjelma jossa List-tietorakenteeseen lisätään satunnaisesti luotuja elokuvia(Movie tietue) 10.000 kappaletta.
//Elokuvan nimessä ja ohjaajan nimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z.
//Laita myös satunnainen vuosiluku.
//Ohjelman tulee tulostaa elokuvien lisäykseen kulunut aika millisekunteina.
//Etsi tämän jälkeen tietorakenteesta 1000 satunnaista elokuvaa nimen perusteella.
//Tulosta löydettyjen elokuvien tiedot sekä hakuun yhteensä kulunut aika millisekuntteina.
//Kokeile samaa Dictionary-rakenteelle käytä avaimena elokuvan nimeä.
//Muista sisällyttää rakenteeseen 10.000 alkiota ja aloittaa satunnainen haku vasta sen jälkeen.
//Muista että Dictonary kokoelmassa ei voi olla kahta samaa avainta.
//Kommentoi lähdekoodiin millaisia eroja nopeuksissa havaitsit?
