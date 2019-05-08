using System;

namespace ifElse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add the question you want answered here
            //This will constitute the program bases
            Console.WriteLine("What is your experience?");

            //Initialise a variable called exp which converts the string into an Integer using the Parse() method
            int exp = Int32.Parse(Console.ReadLine());
            
            //Place the exp variable as a parameter in the TestExperience method which is called when the Program is started
            TestExperience(exp);
        }

        public static void TestExperience(int exp)
        {
            //Set up an initial IF plus condition to evaluate to TRUE
            if (exp < 2000)
            {
                //Add code to be executed
                Console.WriteLine("You are Level 1 - toughen up!");
            }
            //Set up multiple else if statements with corresponding conditions and code blocks
            else if (exp < 4000)
            {
                Console.WriteLine("You are Level 2 - getting better");
            }
            else if (exp < 8000)
            {
                Console.WriteLine("You are Level 3 Adventurer");
            }
            //Set up a termimating ELSE to be executed if none of the conditions are satisfied
            else
            {
                Console.WriteLine("You strive for Level 4");
            }
        }
    }
}
