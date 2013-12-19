using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnglesInTime
{
    public class TimeAngles : ITimeAngles
    {
        public float TimeAngle(int year, int month, int day, int hour, int minute, int second)
        {
            float angle = 0;
            DateTime Date = new DateTime(year, month, day, hour, minute, second);
            int Hour = Date.Hour;
            int Minute = Date.Minute;

            const int HourAngle = 30;
            const int MinuteAngle = 6;
            float HourShift = 0.5f * Minute;

            angle = Math.Abs((Hour * HourAngle) - (Minute * MinuteAngle)- HourShift);

            if(angle > 180)
            {
                angle = 360 - angle;
            }



            

            return angle;
        }
    }
}
