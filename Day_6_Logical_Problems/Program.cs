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
                    Fibonacci fibonacci = new Fibonacci();
                    break;
                case 2:
                    Perfect perfect = new Perfect();
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

    class Fibonacci
    {
        public Fibonacci()
        {
            Console.Write("Enter First Term: ");
            int First_Term = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Term: ");
            int Second_Term = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number of Terms: ");
            int Number_of_Terms = Convert.ToInt32(Console.ReadLine());
            int Third_Term = 0;

            Console.WriteLine("The series is as follows,");
            Console.Write("{0} {1} ", First_Term, Second_Term);
            for (int i = 1; i <= Number_of_Terms; i++)
            {
                Third_Term = First_Term + Second_Term;
                Console.Write("{0} ", Third_Term);
                First_Term = Second_Term;
                Second_Term = Third_Term;
            }
        }
    }

    class Perfect
    {
        public bool Factors(int Number, int Potential_Factor)
        {
            if (Number % Potential_Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Perfect()
        {
            int Check = 0;
            Console.Write("Enter the number you want to check: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Number / 2; i++)
            {
                if (Factors(Number, i))
                {
                    Check += i;
                }
            }

            if (Check == Number)
            {
                Console.WriteLine(Number + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(Number + " is not a Perfect Number.");
            }
        }
    }
}