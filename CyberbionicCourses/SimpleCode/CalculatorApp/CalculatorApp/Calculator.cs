using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Mul(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Div(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}

