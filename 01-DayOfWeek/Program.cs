using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();
            DateTime day = DateTime.ParseExact(dateAsString, "d-M-yyyy"
                , CultureInfo.InvariantCulture);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
