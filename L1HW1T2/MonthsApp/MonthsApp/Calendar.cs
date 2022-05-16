using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsApp
{
    class Calendar : IEnumerable, IEnumerator
    {
        private readonly int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private readonly int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int _position = -1;
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position < months.Length - 1)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => months[_position] + "-" + days[_position];

        public string GetDataByMonths(int month)
        {
            string tempMonth = String.Empty;

            for (int i = 0; i < month; i++)
            {
                if (months[i] == month)
                {
                    tempMonth += months[i] + " - " + days[i] + "\n";
                }
            }

            return tempMonth;
        }

        public string GetDataByDays(int day)
        {
            string tempDay = String.Empty;

            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == day)
                {
                    tempDay += days[i] + " - " + months[i] + "\n";
                }
            }

            return tempDay;
        }
    }
}
