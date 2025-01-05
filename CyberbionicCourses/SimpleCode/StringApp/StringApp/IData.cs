namespace StringApp
{
    interface IData
    {
        string[] GetStringArray(params string[] arr);
        int[] GetNumbersArray(int userValue, ref int index);
    }
}