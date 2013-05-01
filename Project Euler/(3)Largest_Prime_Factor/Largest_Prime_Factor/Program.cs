using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)//======================BEGIN MAIN=================================================
        {
            //The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143?  
 
            Int64 number = 600851475143;
            int max = (int)Math.Sqrt(number);
            while (max > 0)
            {
                if (max % 2 == 0)
                {
                    max--;
                }

                if (number % max == 0)
                {
                    if (IsPrime(max))
                    {
                        Console.WriteLine("Answer: " + max);
                        break;
                    }
                }
                max -= 2;
            }

            Console.ReadLine(); //This is the tail of the machine.
        } //===================================================END MAIN===================================================

        private static bool IsPrime(Int64 number)//=============BEGIN ISPRIME===============================================
        {
            if (number % 2 == 0) //if number is divisible by 2...
            {
                if (number == 2) //and number actually IS 2...
                {
                    return true; //return true, as 2 is prime.
                }
                return false; //otherwise, return everything else divisible by 2 as false. This weeds out all even numbers before it gets crunched below.
            }

            int max = (int)Math.Sqrt(number); //making the highest tested value the square root of number, prevents doubling efforts.

            for (int i = 3; i <= max; i += 2) //starting i at 3 because 2 is already taken care of
            {
                if ((number % i) == 0) //each i up to max will be tested with odd numbers (3, 5, 7, 9, etc) and test it against the number. if no remainder...
                {
                    return false; // it does not pass.
                }
            }
            return true; //otherwise, IsPrime loves you, wants you to pass. Return true and be counted!
        }//===================================================END ISPRIME=================================================
    }
}
