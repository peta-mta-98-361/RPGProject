using System;

namespace switch_StatementRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add in multiple questions you want to ask
            //Assign the results from these questions to variables
            //Convert the ones that need to be Integers using the Int32.Parse() method

            Console.WriteLine("What character profession are you? (Fighter, Mage, Barbarian or Thief)");
            string profChoice = Console.ReadLine();
            Console.WriteLine("What is your Strength score?");
            int str = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your constitution score?");
            int con = Int32.Parse(Console.ReadLine());

            //Specify the method to be run with the parameters in the parentheses
            testSwitch(str, con, profChoice);
        }

        //Write the method with corresponding arguments
        public static void testSwitch(int str, int con, string profChoice)
        {
            //Create an empty variable called result
            int result;

            //initialise the switch using profChoice as the switcher
            switch (profChoice)
            {
                //Add in multiple cases covering the different ways to write the professions
                case "Fighter":
                case "FIGHTER":
                case "fighter":
                    //Calculate the result of this profession
                    result = str + con;
                    //End the switch
                    break;
                //Repeat for other cases
                case "Mage":
                case "MAGE":
                case "mage":
                    result = str - con;
                    break;
                case "Barbarian":
                case "BARBARIAN":
                case "barbarian":
                    result = str * con;
                    break;
                case "Thief":
                case "THIEF":
                case "thief":
                    result = str / con;
                    break;
                //Add a default case in the event the entered profession does not exist
                //Provide some explanatory text
                default:
                    Console.WriteLine("The profession is not recognised");
                    return;
            }

            //As Barbarian is a special case, use an if...else decision structure for Barbarians
            if ((profChoice == "Barbarian") || (profChoice == "barbarian") || (profChoice == "BARBARIAN"))
            {
                Console.WriteLine("Your beserker physical attack damage modifier will be {0}", result);
                return;
            }
            //Otherwise return a default message
            else
            {
                Console.WriteLine("Your attack modifier is {0}", result);
                return;
            }
            
        }
    }
}
