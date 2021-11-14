using ArithmeticCalculatorApp.Model;

namespace ArithmeticCalculatorApp
{
    public class Calculator
    {
        private readonly Data _operandA;
        private readonly Data _operandB;

        public double Adds(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multipliplies(double a, double b)
        {
            return a * b;
        }

        public double Divides(double a, double b)
        {
            return a / b;
        }

        public double DividesRemainder(double a, double b)
        {
            return a % b;
        }
    }
}