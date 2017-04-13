using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);

         

            int[] reverse = ReverseArray(numbers);
            //ReverseA(numbers);
            PrintNumbers(numbers);
            PrintNumbers(reverse);

           

            Console.ReadKey();

        }

        static int[] GenerateNumbers(int arrayLength)
        {
            int[] newArray = new int[arrayLength];
            Random randNumber = new Random();
           
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = randNumber.Next(1 , 100);
                }
            return newArray;  
        }

        static int[] ReverseArray(int[] numbers)
        {

            int[] reverseArray = new int[numbers.Length];

            for(int j = 0; j < numbers.Length; j++)
                {
                    reverseArray[j] = numbers[j];
                }
            
            for (int i = 0; i < reverseArray.Length / 2; i++)
            {
                int tmp = reverseArray[i];
                reverseArray[i] = reverseArray[reverseArray.Length - i - 1];
                reverseArray[reverseArray.Length - i - 1] = tmp;
            }
            return reverseArray;
        }


        static void PrintNumbers(int[] array)
        {
            for(int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " , ");    
            }
            Console.WriteLine("--------------------");
        }
       
    }
}
