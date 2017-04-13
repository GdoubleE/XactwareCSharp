using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciChapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Fibonacci Zone");

            bool keepGoing = true;
            ///<summary>
            ///loops through a question to allow the user to enter as many numbers as they want 
            /// </summary>

            while (keepGoing != false)
            {
                
                Console.WriteLine("Enter a number between 1 and 30 to see it's Fibonacci value");
                Console.WriteLine("press x at anytime to exit the program");

                string userInput = Console.ReadLine();

                if (userInput == "x")
                {
                    keepGoing = false;
                    Console.WriteLine("Have a nice day");
                   
                }
                else
                {

                    int num = Convert.ToInt32(userInput);
                    Console.WriteLine($"Your fibonacci value is {Fibonacci(num)}");
                    keepGoing = true;
                }
                    

            }

                
          

            Console.ReadKey();


        }

        /// <summary>
        /// Finds the value of the fibonacci sequence number based on the user's input ie fibonacci for 3 is 2 etc.
        /// </summary>
        /// <param name="num">
        /// any number that the user chooses between 1 and 30 (to make it easier)
        /// </param>
        /// <returns>
        /// returns the fibonacci number 
        /// </returns>
        static int Fibonacci(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);

        }
            

            

    }
}
