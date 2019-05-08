using System;

namespace doWhile_StatementRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("It will take {0} hours to recover {0} health", i);
                i++;

            }
            while (i <= 12);
        }
    }
}
