namespace StringApp
{
    class Data : IData
    {
        public string[] GetStringArray(params string[] arr)
        {
            return new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        }

        public int[] GetNumbersArray(int userValue, ref int index)
        {
            int[] numbers = new int[10];
            int nextDigit;

            do
            {
                nextDigit = userValue % 10;
                numbers[index] = nextDigit;
                index++;
                userValue = userValue / 10;
            } while (userValue > 0);

            index--;

            return numbers;
        }
    }
}
