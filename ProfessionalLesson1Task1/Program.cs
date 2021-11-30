using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProfessionalLesson1Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            //foreach (var item in GetCollection(arr))
            //    Console.WriteLine(item);

            foreach (var item in GetYieldCollection(arr))
                Console.WriteLine(item);
        }

        static public IEnumerable<double> GetCollection(int[] arr)
        {
            return from item in arr
                   where item % 2 != 0
                   select (Math.Pow((double)item, 2));
        }

        static public IEnumerable<double> GetYieldCollection(int[] arr)
        {
            foreach (var item in arr)
                if (item % 2 != 0)
                    yield return Math.Pow(item, 2);
        }

    }
}
