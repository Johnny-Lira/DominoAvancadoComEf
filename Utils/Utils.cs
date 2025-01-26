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

        public static DateTime BrasiliaTimeAddDays(int days)
        {
            var brasiliaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            var brasiliaTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow.AddDays(days), brasiliaTimeZone);
            return brasiliaTime;
        }
    }
}
