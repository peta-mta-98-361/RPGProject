
using System;

namespace for_StatementRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
            HpTest();
        }

        private static void ForTest()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
        }

        private static void HpTest()
        {
            Console.WriteLine("\nTest what happens when Hit Points (HP) decrement to 0?");
            for (int j = 16; j >= 0; j--)
            {
                if (j > 0)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.WriteLine("You have no hit points - you are dead!");
                }
            }
        }
    }
}
