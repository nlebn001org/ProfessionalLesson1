using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson1Task3
{
    class MyCollection<T> : IEnumerator<T>, IEnumerable<T> where T : Citizen
    {
        T[] arr = new T[0];

        #region hide
        int position = -1;

        public T Current => arr[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            position++;
            if (position > arr.Length)
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

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        public void Add(T citizen)
        {
            if (citizen == null) return;
            if (arr.Contains(citizen)) return;
            Array.Resize(ref arr, arr.Length + 1);

            if (citizen.GetType() == typeof(Retiree))
            {
                int lastRet = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].GetType() != null && arr[i].GetType() != typeof(Retiree))
                        lastRet = i - 1;
                    break;
                }
                for (int i = arr.Length; i > lastRet + 1; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[lastRet + 1] = citizen;
                return;
            }

            arr[arr.Length - 1] = citizen;
        }
    }
}
