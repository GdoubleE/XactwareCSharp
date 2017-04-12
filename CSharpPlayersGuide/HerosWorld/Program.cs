using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            Console.WriteLine("Enter Your Hero's Name: ");
            string heroName = Console.ReadLine();
            bool validName = false;
            while (!validName)
            {
                if(heroName.Contains("Legolas"))
                {
                    validName = false;
                    Console.WriteLine("try again son!");
                    heroName = Console.ReadLine();

                }
                else
                {
                    validName = true;
                }
            }
            Console.WriteLine($"your new name is {heroName}!");

        }
    }
}
