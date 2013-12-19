using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnglesInTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date1 = new DateTime(2013, 12, 18, 6, 30, 00);

            const int HourDegree = 30;
            const int MinuteDegree = 6;

            int hour = Date1.Hour;
            int minute = Date1.Minute;
            float hourShift = .5f * minute;

            float FinalAngle = Math.Abs((hour * HourDegree) - (minute * MinuteDegree) - hourShift);
            //FinalAngle = Math.Abs(FinalAngle - hourShift);

            if (FinalAngle > 180)
            {
                FinalAngle = 360 - FinalAngle;
            }

            Console.WriteLine("Given Time: " + hour + ":" + minute);
            Console.WriteLine("Smallest Angle Based on Given Time: " + FinalAngle );
            Console.WriteLine("Amount of HourShift: " + hourShift);
        }
    }
}
