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

        List<T> list = new List<T>();

        public void Add(T citizen)
        {
            if (citizen == null) return;
            if (list.Contains(citizen)) return;
            if (citizen.GetType() == typeof(Retiree))
            {
                var lastRet = (from ret in list where ret.GetType() == typeof(Retiree) select ret).Count();
                list.Insert(lastRet, citizen);
            }
            else
                list.Add(citizen);
        }
        public void Remove()
        {
            list.RemoveAt(0);
        }
        public void RemoveByCitizenType(Type type)
        {
            list.RemoveAll(x => x.GetType() == type);
        }
        public void RemoveByCitizen(Citizen citizen)
        {
            if (list.Contains(citizen))
                list.RemoveAll(x => x.Equals(citizen));
        }
        public (bool, int?) Contains(Citizen citizen)
        {
            return list.Contains(citizen) ? (true, list.IndexOf((T)citizen)) : (false, null);
        }
        public (Citizen, int) LastCitizen()
        {
            return (list.Last(), list.Count - 1);
        }
        public void Clear()
        {
            list.Clear();
        }

        #region Interfaces realization
        int position = -1;

        public T Current => list[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            position++;
            if (position > list.Count - 1)
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
    }
}
