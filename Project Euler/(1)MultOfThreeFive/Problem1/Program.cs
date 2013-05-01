using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfThree = 0;
            int sumOfFive = 0;
            int sumOfDups = 0;
            int total = 0;

            
            sumOfThree = sumOfMultiples(3, 1000);
            sumOfFive = sumOfMultiples(5, 1000);
            sumOfDups = sumOfMultiples(15, 1000);

            total = sumOfThree + sumOfFive - sumOfDups;

            Console.WriteLine(String.Format("Answer: {0}", total.ToString()));

            Console.ReadLine();
        }

        private static int sumOfMultiples(int multOf, int max)
        {
            int sum = 0;
            int mult = 1;

            for (int i = multOf; i < max; i+= multOf)
            {
                sum += multOf * mult;
                mult++;
            }

            return sum;
        }
    }
}
