using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    public class PosOrNeg
    {
        public static int UserNumber()
        {
            Console.Write("Enter A Number:  ");
            int userNumber = Convert.ToInt16(Console.ReadLine());
            return userNumber;
        }

        public static void EvenOdd()
        {
            int firstNumber = UserNumber();
            int divisible = firstNumber % 2;

            if (divisible != 0)
            {
                Console.WriteLine("This is an ODD number!");
            }
            else
            {
                Console.WriteLine("Your number be EVEN Steven!");
            }
            
        }

    }
}

       


          

            

           

        
    

