using System;

namespace if_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two variables called baseExp and currentExp
            int baseExp, currentExp;
            //Set their values to 0 and 2000 respoectively
            baseExp = 0;
            currentExp = 2000;

            //Run the if statement with the condition you are evaluating in the parentheses
            if (currentExp < baseExp)
            {
                //Place the desired output here if the condition returns TRUE
                Console.WriteLine("Level Up! You are now blessed with more experience than you started with");
            }
            else
            {
                //Place the code which executes if the statement returns FALSE here 
                Console.WriteLine("You need to work harder");
            }
        }
    }
}
