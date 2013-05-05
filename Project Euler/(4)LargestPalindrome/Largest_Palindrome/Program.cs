using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           /*A palindromic number reads the same both ways. The largest palindrome made from the product of two
            * 2-digit numbers is 9009 = 91 x 99. Find the largest palindrome made from the product of two 3-digit
            * numbers.*/

            /* Condition 1: the 2 factors have to be 3 digits.
             * 999 x 999 decrementing to > 99
             * step1: multiply together. 999*999 = 998001
             * step2: convert product to string
             * step3: reverse
             * step4: once reversed, compare with original
             * step5: if reverse != original, continue, else break and display answer.
             * step6: 
            */


//============================================BEGIN VARIABLE DECLARATION==============================================
            string digitsStr = args[0];
            int num1;
            int num2;
            int num3;
            int digits = int.Parse(digitsStr);
            double lowest;
            int largestPalindrome = 0;
            string num3Str;
            string num3StrRev;
            CharEnumerator num3Enum;
//===========================================END VARIABLE DECLARATION=================================================

            lowest = Math.Pow(10, digits - 1);
            num1 = (int)Math.Pow(10, digits) - 1;
            num2 = num1;

            while (num1 >= lowest)
            {
                num3 = num1 * num2;
                num3Str = num3.ToString();
                num3Enum = num3Str.GetEnumerator();
                num3StrRev = String.Empty;

                
                while (num3Enum.MoveNext())
                {
                   num3StrRev = num3Enum.Current.ToString() + num3StrRev;
                }

                if (num3Str == num3StrRev)
                {
                    //Console.WriteLine(num1 + "x" + num2 + "=" + num3);
                    if (num3 > largestPalindrome)
                    {
                        //Console.WriteLine("I found a larger palindrome.");
                        
                        //Console.WriteLine(num1 + "x" + num2 + "=" + num3);
                        largestPalindrome = num3;  
                    }
                }

                num2--;

                if (num2 < lowest || num3Str == num3StrRev)
                {
                    num1--;
                    num2 = num1;
                }  
            }
            Console.WriteLine(num1 + "x" + num2 + "=" + num3);
            Console.WriteLine("Answer: " + largestPalindrome); //906609
        }
    }
}
