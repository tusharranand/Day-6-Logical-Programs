using System;

namespace Day_6_Logical_Problems
{
    class Brancher
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a number to go to the respective problem, \n");
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect Number");
            Console.WriteLine("3 for Prime Numer");
            Console.WriteLine("4 for Reverse a Number");
            Console.WriteLine("5 for Coupon Numbers");
            Console.WriteLine("6 for Simulate a Stopwatch Program \n");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    break;
            }
        }
    }
}