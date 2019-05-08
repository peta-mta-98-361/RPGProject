using System;

namespace Recursion_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 145;
            Console.WriteLine("The factorial  of {0} is {1}", n, Factorial(n));

            Console.WriteLine("What is the level");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You need {0} experience points to reach Level {1}", experienceLeveller(m), m);
        }

        public static double Factorial(double n)
        {
            if (n == 0)
            {
                //base case
                return 1;
            }
            else
            {
                //factorial case
                return n * Factorial(n - 1);
            }
        }


        public static double experienceLeveller(int m)
        {
            if (m == 0)
            {
                return 0;
            }
            else
            {
                //When the entered value is not zero than carry out the recursive function
                //Start from a base of 1000
                //Now multiply that by 2 to the power of m-1
                //Continue with this until you reach the base case

                return 1000 * (Math.Pow(2, m - 1));
            }
        }

    }
}
