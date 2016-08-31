using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyPaid
{
    class DailyPaid
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double cours = double.Parse(Console.ReadLine());

            double montPaid = workDays * moneyPerDay;

            double yearPaid = montPaid * 12 + montPaid * 2.5;

            double tax = yearPaid * 0.25;

            double cleanYearPaid = (yearPaid - tax) * cours;

            double middlePaidPerDay = cleanYearPaid / 365;

            Console.WriteLine("{0:0.00}",middlePaidPerDay);
        }
    }
}
