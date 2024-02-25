using BABank.BaseEntities;
using BABank.Entities.Accounts;
using BABank.Shared.Queues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Shared
{
    public class DayReport<T> : BaseQueue<Customer>, ICollection<T>
    {
        private static DayReport<T> _endDayReport;

        public static DayReport<T> GetInstance
        {
            get { return _endDayReport is null ? _endDayReport = new DayReport<T>() : _endDayReport; }
        }

        private DayReport()
        {
            _endDayReport = new DayReport<T>();
        }

        public void Add(T item)
        {
            _endDayReport.Add(item);
        }

        public bool Contains(T item)
        {
            return _endDayReport.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _endDayReport.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _endDayReport.Remove(item);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)_endDayReport;
        }
    }
}
