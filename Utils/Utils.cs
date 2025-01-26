using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DominoAvancadoComEf.Utils
{
    public class Utils
    {
        public static DateTime BrasiliaTimeNow()
        {
            var brasiliaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
            var brasiliaTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, brasiliaTimeZone);
            var utcDate = DateTime.SpecifyKind(brasiliaTime, DateTimeKind.Utc);
            return utcDate;
        }

        public static DateTime BrasiliaTimeAddDays(int days)
        {
            var brasiliaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
            var brasiliaTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow.AddDays(days), brasiliaTimeZone);
            var utcDate = DateTime.SpecifyKind(brasiliaTime, DateTimeKind.Utc);
            return utcDate;
        }
    }
}
