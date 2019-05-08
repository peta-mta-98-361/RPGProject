using System;

namespace while_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 12)
            {
                Console.WriteLine("It will take {0} hours to recover {0} health", i);
                i++;
            }
        }
    }
}
