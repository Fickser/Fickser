using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sum_Square_Difference
{
    class Program
    {
        //Find the difference between the sum of the squares of the first one hundred
        //natural numbers and the square of the sum.

        static void Main(string[] args)
        {


            int naturalNumber = 1;
            double numbersSquared;
            double numberSquaredTotal = 0;
            double SquareOfSums = 0;
            int total;

            while (naturalNumber <= 100)
            {

                numbersSquared = Math.Pow(naturalNumber, 2);

                numberSquaredTotal = numberSquaredTotal + numbersSquared;

                SquareOfSums += naturalNumber; 

                naturalNumber++;
            }

            SquareOfSums = Math.Pow(SquareOfSums, 2);

            total = (int)SquareOfSums - (int)numberSquaredTotal;
            Console.WriteLine("Square of Sums: " + SquareOfSums);
            Console.WriteLine("Sum of Squares: " + numberSquaredTotal);
            Console.WriteLine(SquareOfSums + "-" + numberSquaredTotal);
            Console.WriteLine("Answer: " + total);


            




        }
    }
}
