using CalcFractionApp.Model;

namespace CalcFractionApp
{
    public class Convertor
    {
        private Fraction _fraction;

        public Convertor(string concatenation)
        {
            _fraction = new Fraction (StringToChar(concatenation)[0], StringToChar(concatenation)[2]);
            
        }

        public char[] StringToChar(string concatenation)
        {
            char[] arr = {concatenation[0], concatenation[2]};
            
            return arr;
        }
    }
}