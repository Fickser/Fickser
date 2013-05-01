using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Even_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1; //delcaring variables
            int num2 = 2;
            int total = 0;

            Console.WriteLine(num2); //displaying the 2 before the loop

            total += num2; //adding the 2 to the total

            while ((num1+num2) < 4000000) //so long as both numbers added together are less than 4 mil...
            {
                num1 = num1+num2; //add the two numbers together
                if (num1 % 2 == 0) //if there is no remainder...
                {
                    Console.WriteLine(num1); //display it
                    total += num1; //then add it to the total
                }
                num2 =num2+num1; //do it again
                if (num2 % 2 == 0)//if there is no remainder again...
                {
                    Console.WriteLine(num2); //display it
                    total += num2; //add it to the total
                }
            } //end of while loop
            Console.WriteLine(String.Format("Answer: {0}", total.ToString())); //total (with commentary)
            Console.ReadLine(); //pause for intermission (or waiting for enter, your choice)                                        
        }
    }
}
