using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CenturiestoMinutes
{
    class CenturiestoMinutes
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int year = century * 100;
            double day = year * 365.2422;
            int hours = (int)day * 24;
            int minute = hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2:f0} days = {3} hours = {4} minutes", century, year, day, hours, minute);
        }
    }
}
