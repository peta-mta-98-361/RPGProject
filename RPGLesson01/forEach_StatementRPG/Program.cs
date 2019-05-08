using System;

namespace forEach_StatementRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachTest();
            ExperienceLadder();
        }

        private static void ForEachTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
        }

        private static void ExperienceLadder()
        {
            Console.WriteLine("\nExperience Checker");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine("\tTo reach level {0} you need {1} experience points", i, i * 1000);
            }
        }
    }
}
