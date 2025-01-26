using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoAvancadoComEf.Utils
{
    public class Utils
    {
        public static DateTime BrasiliaTimeNow()
        {
            var brasiliaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            var brasiliaTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, brasiliaTimeZone);
            return brasiliaTime;
        }
    }
}
