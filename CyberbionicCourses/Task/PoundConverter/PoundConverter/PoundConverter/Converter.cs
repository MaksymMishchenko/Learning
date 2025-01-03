using System;
using PoundConverter.Model;

namespace PoundConverter
{
    public class Converter

    {   // Метод конвертации в фунты
        private decimal ShillingToPennies(decimal shilling, decimal pennies)
        {
            return (MoneyConstants._oldShillings * shilling + pennies) / 2.4m;
        }

        // Метод конвертации из старой денежной системы (фунты, шиллинги, пенсы) в новую (фунты, пенсы).
        private decimal ConvertPenniesToPound(decimal pound, decimal shilling, decimal pennies)
        {
            var pennie = ShillingToPennies(shilling, pennies);

            if (pennie >= 100)
            {
                pound += pennie / 100;
                return Math.Round(pound);
            }
            else
            {
                return pound;
            }
        }

        //Метод конвертации в новую денежную систему
        public NewCurrencyPound NewPound(decimal pound, decimal shilling, decimal pennies)
        {
            var penni = ShillingToPennies(shilling, pennies);
            var newPound = ConvertPenniesToPound(pound, shilling, pennies);

            if (penni > 100)
            {
                return new NewCurrencyPound(newPound, penni - 100);
            }
            else
            {
                return new NewCurrencyPound(newPound, penni);
            }
        }
    }
}