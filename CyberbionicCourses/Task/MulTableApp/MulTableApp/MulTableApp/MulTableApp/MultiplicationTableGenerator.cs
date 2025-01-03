namespace MulTableApp
{
    internal class MultiplicationTableGenerator
    {
        public string[][] Create(int from, int till)
        {
            string[][] array = new string[till-from + 1][];

            for (int i = 0; i < till - from + 1; i++)
            {
                array[i] = new string[9];
            }

            for (int i = 0, d = from; i < till-1; i++, d++)
            {
                for (int j = 0, a = d, b = 2, n = 0; j < array[i].Length; j++, b++)
                {
                    var c = a * b;

                    if (c < 10)
                    {
                        array[i][j] = n.ToString($"{a} *  {b} =  {c}");
                    }

                    else if (b < 10)
                    {
                        array[i][j] = n.ToString($"{a} *  {b} = {c}");
                    }
                    else
                    {
                        array[i][j] = n.ToString($"{a} * {b} = {c}");
                    }
                }
            }
            return array;
        }
    }
}