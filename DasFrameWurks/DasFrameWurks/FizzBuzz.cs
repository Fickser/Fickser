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
              int mod3 = i % 3;
              int mod5 = i % 5;

              if (mod3 == 0 && mod5 !=0)                                
              {                                                         
                  string whatever = i.ToString() + "Fizz";              
                  ReturnSequence.Add(whatever);
              } 
              else if(mod5 == 0 && mod3 !=0)
              {
                  string whatever = i.ToString() + "Buzz";
                  ReturnSequence.Add(whatever);
              }
              else if(mod5 == 0 && mod3 == 0)
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
