using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylindarCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cylindar Calculator program
            Console.WriteLine("Welcome to Cylindar Calculator!");
            Console.WriteLine("---------------------------------");

            
            

            
            double pie = 3.1415926;



            Console.WriteLine("Enter Cylindar height:  ");
            int h = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Enter Cylindar Radius: ");
            int r = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("cylindar height = " + h + " Cylindar radius = " + r);

            double volume = (pie * (r * r)) * h;
            double surfaceArea = (2 * pie * r * (r + h));

            Console.WriteLine("Volume is: " + volume);
            Console.WriteLine("surface area is: " + surfaceArea);
            Console.ReadKey();



        }
    }
}
