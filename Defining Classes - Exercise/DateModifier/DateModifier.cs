using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public int DaysDifference(string firstDateString, string secondDateString)
        {
            DateTime firstDate = DateTime.Parse(firstDateString, CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.Parse(secondDateString, CultureInfo.InvariantCulture);
            TimeSpan difference = firstDate.Subtract(secondDate);

            return difference.Days;
        }
    }
}
