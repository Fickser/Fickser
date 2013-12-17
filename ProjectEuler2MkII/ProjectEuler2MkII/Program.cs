using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2MkII
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 0;
            int total = num2;
            while (num3 <= 4000000)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                if (num3 >= 4000000) { break; }

                if (num3 % 2 != 0)
                {
                    total += num3;
                }
            }
           Console.WriteLine("Sum of Even Numbers Below 4 Million: " + total);
        }
    }
}
