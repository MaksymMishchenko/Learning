using System;

namespace PoundConverter
{
    class PoundConverter
    {
        private const double _oldShillings = 12; //1 шиллинг = 12 пенсов.
        private const double _convertPercent = 2.4;

        //Метод конвертации из старой денежной системы (фунты, шиллинги, пенсы) в новую (фунты, пенсы).
        public string ConvertToPound(double pounds,double userShilling, double userPennies)
        {
            double oldPennies = _oldShillings * userShilling+userPennies;
            double newMoney = oldPennies / _convertPercent;
            
            return pounds + "."+ Math.Round(newMoney);
        }
    }
}
