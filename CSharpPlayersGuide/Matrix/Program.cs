using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initial = new int[] { 4, 8, 13, 7, 24, 65, 10, 9, 11, -1 };

            int[] initCopy = new int[initial.Length];

            for(int i=0; i < initCopy.Length; i++)
            {
                initCopy[i] = initial[i];
                Console.Write(initCopy[i] + ", ");
            }

            for(int j = 0; j < initial.Length; j++)
            {
                Console.Write(initial[j] + ", ");
            }

            Console.ReadKey();

        }
    }
}
