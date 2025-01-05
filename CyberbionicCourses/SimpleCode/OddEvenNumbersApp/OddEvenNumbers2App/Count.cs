namespace OddEvenNumbers2App
{
    public class Count
    {
        public void GetOddEvenNumbers(int currentValue, int limit, ref int oddNumbersCount, ref int evenNumbersCount, ref int oddNumberSum, ref int evenNumberSum)
        {
            for (int i = currentValue; i <= limit; i++)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue;
                    currentValue++;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumberSum += currentValue;
                    currentValue++;
                }
            }
        }
    }
}
