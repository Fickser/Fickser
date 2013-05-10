using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__10001st_Prime_Number
{
    class Program
    {
        static void Main(string[] args)//========================BEGIN MAIN================================
        {
            int number = 2;
            int count = 0;
            int answer = 0;

            while (answer == 0)
            {   
                if (IsPrime(number))
                {
                    count++;
                    if (count == 10001)
                    {
                        Console.WriteLine("Answer: " + number);
                        break;
                    }
                }
                number++;
            }
        }

        private static bool IsPrime(Int64 number)//=============BEGIN ISPRIME=============================
        {
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                return false;
            }

            int max = (int)Math.Sqrt(number);

            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
