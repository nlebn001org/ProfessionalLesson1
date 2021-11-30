using System;
using System.Collections.Generic;

namespace ProfessionalLesson1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection mc = new MonthCollection();
            //Console.WriteLine(mc[12]);

            IEnumerable<(string, int, int)> coll = mc.GetMonthByDays(40);

            foreach ((string, int, int) item in coll)
                Console.WriteLine(item);
        }
    }
}
