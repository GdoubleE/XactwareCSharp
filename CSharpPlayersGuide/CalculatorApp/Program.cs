using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int num1;
            int num2;
            string operand;
            float answer;
            string useCalc = "n";

            //this is the heading for the app
            Console.WriteLine("Welcome to the Calculator App");
            Console.WriteLine("-----------------------------\n");

            //ask the user if they want to use the calculator and retrieve their response
            Console.Write("Do you want to make some calculations? y/n   ");
            useCalc = Console.ReadLine();
            Console.WriteLine("---------------------------------------------\n");

            //this will allow the user to use the calculator more than once 
            while (useCalc != "n")
            { 

                Console.Write("Please enter a number: "); //get the first number
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPlease enter an operand +, -, /, *, ^(power), %(remainder): ");// get the operand
                operand = Console.ReadLine();

                Console.Write("\nPlease Enter another number: "); //get the second number
                num2 = Convert.ToInt32(Console.ReadLine());


                    switch(operand)//switch statement to perform various math functions on the numbers
                    {
                        case "+":
                            answer = num1 + num2;
                            break;
                        case "-":
                            answer = num1 - num2;
                            break;
                        case "/":
                            answer = (float)num1 / (float)num2;
                            break;
                        case "*":
                            answer = num1 * num2;
                            break;
                        case "%":
                            answer = num1 % num2;
                            break;
                        case "^":
                            answer = (float)Math.Pow(num1, num2);
                            break;
                        default:
                            answer = 0;
                            break;
                    }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Answer:  {num1} {operand} {num2} = {answer}"); //display results
                Console.WriteLine("---------------------------------------------");
                Console.Write("\n Care to Try again? y/n  ");//allows to use it again
                useCalc = Console.ReadLine();
                Console.WriteLine();

            }

            Console.ReadKey();




        }
    }
}
