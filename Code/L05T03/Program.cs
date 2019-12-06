using System;

namespace L05T03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            Console.WriteLine("Give me a integer? ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another integer? ");
            num02 = Convert.ToInt32(Console.ReadLine());
            int num03 = num01 + num02;
            Console.WriteLine("Let's count those together, it is: "+num03);

            Console.ReadKey();
        }
    }
}
