using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableApp
{
    class Table
    {
        private int _year1990, _year1991, _year1992, _year1993;
        private int _number1, _number2, _number3, _number4;

        public Table(int value1, int value2, int value3, int value4, int value5, int value6, int value7, int value8)
        {
            _year1990 = value1;
            _year1991 = value2;
            _year1992 = value3;
            _year1993 = value4;
            _number1 = value5;
            _number2 = value6;
            _number3 = value7;
            _number4 = value8;
        }
        //15 минут
        public void PrintOnScreen()
        {
            Console.WriteLine($"{_year1990} \t{_number1} \n{_year1991} \t{_number2}" +
                              $" \n{_year1992} \t{_number3} \n{_year1993} \t{_number4} ");
        }

    }
}
