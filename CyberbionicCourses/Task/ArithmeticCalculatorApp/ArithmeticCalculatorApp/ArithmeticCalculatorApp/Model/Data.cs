namespace ArithmeticCalculatorApp.Model
{
    class Data
    {
        public Data(double operandA, double operandB)
        {
            OperandA = operandA;
            OperandB = operandB;
        }

        public double OperandA { get; set; }
        public double OperandB { get; set; }
    }
}
