using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DasFrameWurks
{
  public class FizzBuzz : IFizzBuzz
    {
      public List<string> GetFizzBuzz(List<int> Values)
      {
          List<string> ReturnSequence = new List<string>();

          foreach(int i in Values)
          {
              if (i%3 == 0 && i%5 !=0)
              {
                  string whatever = i.ToString() + "Fizz";
                  ReturnSequence.Add(whatever);
              } 
              else if(i%5 == 0 && i%3 !=0)
              {
                  string whatever = i.ToString() + "Buzz";
                  ReturnSequence.Add(whatever);
              }
              else if(i%5 == 0 && i%3 == 0)
              {
                  string whatever = i.ToString() + "FizzBuzz";
                  ReturnSequence.Add(whatever);
              }
              else
              {
                  string whatever = i.ToString();
                  ReturnSequence.Add(whatever);
              }
          }

          return ReturnSequence;
      }
    }
}
