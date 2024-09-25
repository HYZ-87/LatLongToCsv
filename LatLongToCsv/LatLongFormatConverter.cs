using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PdfToXlsx
{
    public static class LatLongFormatConverter
    {
        public static string SeperateConsecutiveNumbers(string num)
        {
            Regex rgx = new Regex(@"(?<=\d{2,})\d{2}", RegexOptions.RightToLeft);
            return rgx.Replace(num, " $0");
        }
        public static double DMSToDD(string dms)
        {
            string[] ss = dms.Split(new char[] { ' ' });
            double tmp, sum = 0;
            try
            {
                for (int i = 0, divider = 1; i < ss.Length; i++, divider *= 60)
                {
                    tmp = Convert.ToSingle(ss[i]) / divider;
                    sum += tmp;
                }
            }
            catch { }
            return sum;
        }
    }
}
