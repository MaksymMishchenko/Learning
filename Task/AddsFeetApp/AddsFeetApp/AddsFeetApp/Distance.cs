using System;

namespace AddsFeetApp
{
    public struct Distance
    {
        private int _feet;
        private float _inches;
        private const int _oneFeet = 12;

        public Distance(int feet, float inches)
        {
            _feet = feet;
            _inches = inches;
        }

        public void SumFeetsAndInches(int feet, float inches, ref int tempFeet, ref float tempInches)
        {
            tempFeet = 0;
            float tepmInches = _inches + inches;

            if (tepmInches >= _oneFeet)
            {
                tepmInches -= _oneFeet;
                tempFeet++;
            }

            tempInches = tepmInches;
            tempFeet += _feet + feet;
        }
    }
}
