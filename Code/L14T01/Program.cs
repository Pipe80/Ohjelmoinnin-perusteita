

using System;

namespace LAB14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo14 - Exceptions");

            // division by zero exception
            try
            {
                int number1 = 100;
                int number2 = 0;
                int result = number1 / number2;
                Console.WriteLine("Result is " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero! " + ex.Message);
            }


            // exception in parsing string
            Console.Write("Give a number: ");
            string line = Console.ReadLine();
            try
            {
                int number = int.Parse(line);
                Console.WriteLine("You gave number " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a number: " + ex.Message);
            }


            // exception in accessing array
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Number is " + numbers[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Wrong index used in array: " + ex.Message);
            }


            try
            {
                int result = SafeDivision(100, 0);
                Console.WriteLine("result is " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero: " + ex.Message);
            }

            //SomedaySomething();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static int SafeDivision(int x, int y)
        {
            if (y == 0) throw new System.DivideByZeroException();
            return x / y;
        }

        //static int SomedaySomething()
        //{
        //    throw new NotImplementedException();
        //}
       
    }
}
