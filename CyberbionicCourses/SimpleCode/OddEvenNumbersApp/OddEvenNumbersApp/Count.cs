namespace OddEvenNumbersApp
{
    public class Count
    {
        public void GetOddEvenNumbers(int currentValue, int limit, ref int oddNumbersCount, ref int evenNumbersCount, ref int oddNumberSum, ref int evenNumberSum)
        {
            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumberSum += currentValue;
                }
                currentValue++;
            }
        }
    }
}
