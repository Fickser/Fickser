using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnglesInTime
{
    public interface ITimeAngles
    {
       float TimeAngle(int year, int month, int day, int hour, int minute, int second);
    }
}
