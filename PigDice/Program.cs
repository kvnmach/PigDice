using System;

namespace PigDice
{
    internal class Program
    {
        //public static string Player { get; private set; } 
        private static readonly Random rnd = new Random();

        private static void Main(string[] args)
        {
            //create a title player screen
            TitlePage();

            //create characters
            //generate random numbers for die
            var turnPoints = 0;
            var totalGamePoints = 0;

            while (totalGamePoints < 100)
            {
                while (true)
                {
                   
                    var dice = rnd.Next(1, 7);
                    Console.WriteLine(dice);

                    Console.WriteLine($"You rolled a {dice}.");

                    if (dice == 1)
                    {
                        turnPoints = 0;
                        break;
                    }


                    turnPoints += dice;
                    Console.WriteLine($"Total Score: {totalGamePoints}. This Turn Points: {turnPoints}");


                    Console.WriteLine("Press 'r' to roll again, anything else to bank.");
                    var userInput = Console.ReadLine();
                    if (userInput != "r")
                    {
                        break;
                    }
                }


                totalGamePoints += turnPoints;
                turnPoints = 0;
            }

            Console.WriteLine("You Win!");
            Console.ReadLine();


            // turnTotal += dice;
            //ifdice == 1 


            //while (gt < 100)

            //Roll dice
            //if 1 turn score<0, go to next turn
            // else not 1 add dice roll to turn total
            // ask if bank or roll
            //if b add tt to gt
            //if r loop to while.


            //(player turn loop
            //Sum and hold scores
            //add value to 2 through 6


            //let it loop the value of die


            //create a limit for score

            //create true false values

            //interger for addition
            //end game with >=100
        }

        private static void TitlePage()
        {
            Console.WriteLine("PigDICE!!!!");
            Console.WriteLine("Press any button to Continue!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("['_']");
            Console.WriteLine("rolling dice....");
            Console.ReadLine();
        }
    }
}