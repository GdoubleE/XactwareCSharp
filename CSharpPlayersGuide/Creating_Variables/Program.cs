using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are the interger types
            byte aTinyByte = 114;
            short aMediumNumber = -12345;
            int aLongInterger = 135456412;
            long aSuperBigNumber = -1324563214544;
            sbyte aSignedByte = -124;
            ushort posShort = 12454;
            uint posInterger = 854446542;
            ulong posLongNumber = 45451325451546;
            char singleCharacter = '&';


            //These are the floating point types
            decimal precisionNumber = 0.2535m;
            float floatThisNumber = 0.2124531f;
            double superBigFloater = 0.121354896421354;


            //True or False
            bool rightOrWrong = true;


            //On to the String Types
            string justSomeWords = "This is a string of words";


            decimal triangleArea;
            string baseLengthIn;
            string heightLengthIn;


            Console.WriteLine("Enter Length Of Base:  ");
            baseLengthIn = Console.ReadLine();
            

            Console.WriteLine("Enter Length of Height: ");
            heightLengthIn = Console.ReadLine();
            Console.WriteLine("Base Height = " + baseLengthIn + "Height Length = " + heightLengthIn);

            decimal bLength = Convert.ToDecimal(baseLengthIn);
            decimal hLength = Convert.ToDecimal(heightLengthIn);

            triangleArea = ((bLength * hLength) / 2);

            Console.WriteLine("Area is: " + triangleArea);



            int a = 17;
            int b = 3;
            int quotient = a / b;
            int remainder = a % b;
            int checkResult = b * quotient + remainder;

            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);
            Console.WriteLine(checkResult);


            //Cylindar program area

            


            /*
            Console.WriteLine(aLongInterger);
            Console.WriteLine(aTinyByte);
            Console.WriteLine(aMediumNumber);
            Console.WriteLine(aSuperBigNumber);
            Console.WriteLine(aSignedByte);
            Console.WriteLine(posShort);
            Console.WriteLine(posInterger);
            Console.WriteLine(posLongNumber);
            Console.WriteLine(singleCharacter);
            Console.WriteLine(precisionNumber);
            Console.WriteLine(floatThisNumber);
            Console.WriteLine(superBigFloater);
            Console.WriteLine(rightOrWrong);
            Console.WriteLine(justSomeWords);
     */


            Console.ReadKey();

        }
    }
}
