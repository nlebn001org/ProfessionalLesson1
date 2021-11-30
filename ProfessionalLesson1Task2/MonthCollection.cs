using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson1Task2
{
    class MonthCollection : IEnumerator, IEnumerable
    {

        List<(string, int, int)> months = new List<(string, int, int)>(12);     //name, number, countOfDays

        int position = -1;

        public MonthCollection()
        {
            months.Add(("January", 1, 31));
            months.Add(("February", 2, 28));
            months.Add(("March", 3, 31));
            months.Add(("April", 4, 30));
            months.Add(("May", 5, 31));
            months.Add(("June", 6, 30));
            months.Add(("July", 7, 31));
            months.Add(("August", 8, 30));
            months.Add(("September", 9, 31));
            months.Add(("October", 10, 30));
            months.Add(("November", 11, 31));
            months.Add(("December", 12, 30));
        }

        public (string, int, int) this[int index] => months[index-1];

        public IEnumerable<(string, int, int)> GetMonthByDays(int days)
        {
            foreach (var item in months)
                if (item.Item3 == days)
                    yield return item;
        }

        public object Current => months[position];

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            if (position > months.Count - 1)
            {
                Reset();
                return false;
            }
            return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }

}
