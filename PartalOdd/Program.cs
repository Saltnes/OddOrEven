using System;

namespace PartalOdd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer (whole number) to determine if it is even or odd:");


            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"{num} is an even number.");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is a odd number.");
                    }

                    break;
                }

                {
                    Console.WriteLine("Invalid input. Please enter an integer (whole number).");
                }
            }
        }
    }
}