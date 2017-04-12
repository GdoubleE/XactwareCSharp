using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int number = 1; number <= 100; number++)
            {

                if ((number % 3) == 0 && (number % 5) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if((number % 5)==0)
                {
                    Console.WriteLine("Buzz");
                }
                else if ((number % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                } 
                else
                {
                    Console.WriteLine(number);
                }

            }
            Console.ReadKey();









        }
    }
}
