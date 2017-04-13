using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Die_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roll-A-Die Game");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("How Many Dice will you be rolling?");


            string userChoice = Console.ReadLine();
            int numberOfDice = Convert.ToInt32(userChoice);

            DieRoller(numberOfDice);
           
            Console.ReadKey();
            

            

            



        }

        static void DieRoller(int numberOfDice)
        {
            Random userScore = new Random();
            int counter = 0;
            int dieRoll = 0;
            int totalScore = 0;

            while (counter < numberOfDice)
            {
                dieRoll = userScore.Next(6) + 1;
                totalScore += dieRoll;
                counter++;
                Console.WriteLine($"Roll {counter}:  Score is {dieRoll}.  Total Score is {totalScore}");
            }

            //return totalScore;
        }
    }
}
