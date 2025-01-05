namespace ListExtensionMethodApp
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Returns collections from MyList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.GetLength];

            for (int i = 0; i < list.GetLength; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
