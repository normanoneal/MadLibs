using System;

namespace ONeal_Norman_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Norman O'Neal
            MAdLibs Assignment
            */

            //Objectives
            //Successfully prompt the user and utilize their responses in calculations
            //Convert user responses into usable number data types
            //Create, implement and traverse an array
            //Utilize string concatenationn to create a final story output to the Console


            //User Greeting - utilize Console.WriteLine to welcome the user
            Console.WriteLine("Welcome to Norman's MadLibs I hope you enjoy, press enter!");

            //Prompt the user with next task of choosing an animal 
            Console.WriteLine("Choose an animal name and press enter!");

            //Listen for the response 
            string animalName = Console.ReadLine();

            //Prompt the user to state a name
            Console.WriteLine("Choose a name but choose wisely, then press enter!");

            //Listen for the name response
            string chooseName = Console.ReadLine();

            //Prompt the user to select an adjective
            Console.WriteLine("Now choose an adjective make an AWESOME selection, then press enter!");

            //Listen for the adjective response
            string chooseAdjective = Console.ReadLine();

            //Prompt the user to select a food item
            Console.WriteLine("Choose a food item it can be your favorite or a random thought, then press enter!");

            //Listen for the food selection response
            string foodSelection = Console.ReadLine();

            //Prompt the user to input a year
            Console.WriteLine("Now select a year, any year then press enter!");

            //Listen for the user's year selection
            string userYear = Console.ReadLine();

            //Convert the number into a data type
            double yearSelection = double.Parse(userYear);

            //Prompt to select a dollar amount
            Console.WriteLine("Choose a dollar amount, then press enter!");

            //Listen for the user's dollar response
            string userDollar = Console.ReadLine();

            //Convert the dollar amount into a data type
            double dollarSelection = double.Parse(userDollar);

            //Prompt the user to select a random number
            Console.WriteLine("Select the first number that comes to mind, then press enter!");

            //Listen for the user's number response
            string userNumber = Console.ReadLine();

            //Convert the number into a data type
            double numberSelection = double.Parse(userNumber);

            //Construct a narrative text that will go with the user's responses

            //Narrative Text example (layout)
            /*
            In a galaxy far, far......FAAAAARRRR away where time stood still.
            It was a great (animalName) by the name of (chooseName). He was a great warrior who yielded a large
            (chooseAdjective) Sword named Devastator. (chooseName) had a passion for food not only was he a great warior, but he was a reknowned
            food critic with a acquired taste for (foodName). He remembered back in (userYear) there was a place called 3rd (foodName) From the Left
            where a plate of (foodName) costed (userDollar). The only issue was he was currently (userNumber) miles away but ran out of gas, so he decided
            to call to see if they delivered. They were out of business. THE END!
            */

            //Type of the narrative text in console.WriteLine utilizing concatenations
            Console.WriteLine("In a galaxy far, far........FAAAAARRRR away where time stood still. It was a great " +animalName+ " by the name of " +chooseName+
            ". He was a great warrior who yielded a " +chooseAdjective+ " sword name Devastator. " +chooseName+ " had a passion for food, you see not only was" +
            " he a great warrior, but he was a reknowned food critic with an acquired taste for " +foodSelection+ ". He remembered back in StarDate " +yearSelection+ " there was a" +
            " placed called 3rd " +foodSelection+ " From the Left where a combo was $" +dollarSelection+ ". The only issue was his current position put him exatcly at "
            +numberSelection+ " miles away but his gas ration was depleted. So he called to see if they delivered. They were no longer in business. SAD!");


            
            //I hope you enjoyed my story as much as I enjoyed writing this program!
            












        }
    }
}
