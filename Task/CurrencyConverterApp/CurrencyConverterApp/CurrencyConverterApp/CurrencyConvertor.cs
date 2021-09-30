using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    public class CurrencyConvertor
    {
        private float _dollar = 10.0F;
        private float _pound = 1.487F;
        private float _franc = 0.172F;
        private float _mark = 0.584F;
        private float _yen = 0.00955F;

        public float ConvertDollarToPound(float dollar, float pound)
        {
            return dollar / pound;
        }

        public float ConvertDollarToFranc(float dollar, float franc)
        {
            return dollar / franc;
        }

        public float ConvertDollarToMark(float dollar, float mark)
        {
            return dollar / mark;
        }

        public float ConvertDollarToYen(float dollar, float yen)
        {
            return dollar / yen;
        }
    }
}