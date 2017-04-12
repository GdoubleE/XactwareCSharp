using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPrinter
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 1;
            for(int row = 10; row >= 1; row--)
            {

                for (int space = row - 1; space >= 1 ; space--)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= count; star++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                    
                }
                count++;
                
                
                Console.WriteLine();
           
            }
            Console.ReadKey();



        }
    }
}
