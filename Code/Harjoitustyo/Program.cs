using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustyo
{
    class Program
    {
        public static void Greetings(string yourName, string yourLastName)
        {
            Console.WriteLine("Welcome to the program:" + yourName + " " + yourLastName);

        }
        public static void Age(int age)
        {
            if (age <= 13)
            {
                Console.WriteLine("Heyyy Duuud?");
            }
            else if (age >= 14 && age <= 26)
            {
                Console.WriteLine("What's up teenager?");
            }
            else if (age >= 27 && age <= 56)
            {
                Console.WriteLine("You are like redwine, getting better when older!");
            }
            else
                Console.WriteLine("Exelent, you've made this far");

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Give me your name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("And lastname: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName);
            Greetings(firstName, lastName);

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Age(age);
            Console.WriteLine("Press something to continue..\n");
            Console.ReadKey();

            Console.WriteLine("I like games, these are my favorites: ");
            string[] games = { "Horizon Zero Dawn", "The Last Of Us", "Death Stranding", "Days Gone", "Spiderman"};

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("Press something to continue..\n");
            Console.ReadKey();

            string[] animals = { "Dog", "Cat", "Guineapig", "Horse" };
            string[] nickNames = {"Pawws","Spot","Fox","Drake","Champion","Hawk" };
            Console.WriteLine("So, I like animals and my favorite one is "+animals[0] +" and his nickname is "
                +nickNames[1]+". Do you have favorite animal? (Yes/No)");
            string animal=Console.ReadLine();

                if (animal == "Yes" || animal == "yes")
                {
                    Console.WriteLine("If you have pets you already know the joy and love they bring to your life. " +
                        "Science is confirming just how good they really are for you — both mentally and physically. ");
                }
                else if (animal == "No" || animal == "no")
                {
                    Console.WriteLine("It's easier to travel and see the world, when you don't have to worry about your pets.");
                }

                else
                {
                    Console.WriteLine("That is not right answer, what were you thinking? ");
                }
            Console.WriteLine("Press something to continue..\n");
            Console.ReadKey();

            Console.WriteLine("                 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("          xxxxxxx                             xxxxxx");
            Console.WriteLine("        xxxxxxx                                    xxxxx");
            Console.WriteLine("      xxxxx                                          xxxxx");
            Console.WriteLine("   xxxxx                                                xxxxx");
            Console.WriteLine("  xxxxx                xxxxx          xxxxx               xxxxx");
            Console.WriteLine("xxxxx                                                       xxxxx");
            Console.WriteLine("xxxxx                           xxxxx                       xxxxx");
            Console.WriteLine("  xxxxx         x               xxxxx           x          xxxxx");
            Console.WriteLine("    xxxxxx       x                             x          xxxx");
            Console.WriteLine("      xxxxxx      x                           x         xxxxx");
            Console.WriteLine("         xxxxx     xxxxxxx              xxxxxxx         xxxx");
            Console.WriteLine("           xxx            xxxxxxxxxxxxxx              xxx");
            Console.WriteLine("              xxx                                 xxx");
            Console.WriteLine("                 xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");

            Console.WriteLine("Thank you for using my program, press something to quit...");
            Console.ReadKey();




        }

    }
}


