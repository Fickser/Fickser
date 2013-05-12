using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Largest_Product_In_A_Series
{
    class Program
    {
        static void Main(string[] args)
        {
           // Find the greatest product of five consecutive digits in the 1000-digit number.

            string ThousandDigitNumber = "73167176531330624919225119674426574742355349194934" +
                                         "96983520312774506326239578318016984801869478851843" +
                                         "85861560789112949495459501737958331952853208805511" +
                                         "12540698747158523863050715693290963295227443043557" +
                                         "66896648950445244523161731856403098711121722383113" +
                                         "62229893423380308135336276614282806444486645238749" +
                                         "30358907296290491560440772390713810515859307960866" +
                                         "70172427121883998797908792274921901699720888093776" +
                                         "65727333001053367881220235421809751254540594752243" +
                                         "52584907711670556013604839586446706324415722155397" +
                                         "53697817977846174064955149290862569321978468622482" +
                                         "83972241375657056057490261407972968652414535100474" +
                                         "82166370484403199890008895243450658541227588666881" +
                                         "16427171479924442928230863465674813919123162824586" +
                                         "17866458359124566529476545682848912883142607690042" +
                                         "24219022671055626321111109370544217506941658960408" +
                                         "07198403850962455444362981230987879927244284909188" +
                                         "84580156166097919133875499200524063689912560717606" +
                                         "05886116467109405077541002256983155200055935729725" +
                                         "71636269561882670428252483600823257530420752963450";

            string[] TDN_Array = new string[ThousandDigitNumber.Length];
             CharEnumerator EnumThousandDigitNumber;
             int count = 0; 

             int slot1 = 0;
             int slot2 = 1;
             int slot3 = 2;
             int slot4 = 3;
             int slot5 = 4;

             int product1 = 0;
             int product2 = 0;
             int product3 = 0;
             int product4 = 0;
             int product5 = 0;
             int greatestProduct = 0;

             int total = 0;

             EnumThousandDigitNumber = ThousandDigitNumber.GetEnumerator();

             while (EnumThousandDigitNumber.MoveNext())
             {
                 //for (int i = 0; i < 5; i++) //ThousandDigitNumber.Length
                //{
                    TDN_Array[count] = EnumThousandDigitNumber.Current.ToString();
                    count++;
                //}
             }

             for (int i = 0; i < ThousandDigitNumber.Length - 5; i++)
             {


                 product1 = Convert.ToInt32(TDN_Array[slot1]);
                 product2 = Convert.ToInt32(TDN_Array[slot2]);
                 product3 = Convert.ToInt32(TDN_Array[slot3]);
                 product4 = Convert.ToInt32(TDN_Array[slot4]);
                 product5 = Convert.ToInt32(TDN_Array[slot5]);

                 Console.WriteLine("Slot1: " + product1);
                 Console.WriteLine("Slot2: " + product2);
                 Console.WriteLine("Slot3: " + product3);
                 Console.WriteLine("Slot4: " + product4);
                 Console.WriteLine("Slot5: " + product5);
                 total = product1 * product2 * product3 * product4 * product5;
                 Console.WriteLine("Product of slots 1-5: " + total);
                 if (total > greatestProduct)
                 {
                     greatestProduct = total;
                 }

                 slot1++;
                 slot2++;
                 slot3++;
                 slot4++;
                 slot5++;
             }
             Console.WriteLine("The Greatest Product of 5 consecutive digits is: " + greatestProduct);
        }
    }
}
