using System;
namespace Ply.Utils
{
    public static class DateTimeUtils
    {
        public static string ConvertDateToStr(DateTime date, string format = "yyyy-MM-dd")
        {
            return date.ToString(format);
        }
    }
}
