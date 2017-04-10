using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Positive or Negative Question Answerer");


            int num1 = FirstUserNumber();

            int num2 = SecondUserNumber();

            PositiveNegativeCheck(num1, num2);

            
            PosOrNeg.EvenOdd();



            Console.ReadKey();
            
        }

        private static void PositiveNegativeCheck(int num1, int num2)
        {
            

            if (num1 > 0)
            {
                if (num2 > 0)
                {
                    Console.WriteLine(" Your Result will be positive");
                }
                else if (num2 < 0)
                {
                    Console.WriteLine(" Your Result will be negative");
                }
            }
            else if (num1 < 0)
            {
                if (num2 < 0)
                {
                    Console.WriteLine(" Your Result will be positive");
                }
                else if (num2 > 0)
                {
                    Console.WriteLine(" Your Result will be negative");
                   
                }

            }
        }

        private static int FirstUserNumber()
        {
            Console.Write("Enter First Number:  ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            return num1;
        }

        private static int SecondUserNumber()
        {
            Console.Write("Enter Second Number:  ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            return num2;
        }
    }

}
