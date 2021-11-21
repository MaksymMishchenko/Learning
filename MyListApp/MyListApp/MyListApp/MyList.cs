using System;

namespace MyListApp
{
    class MyList
    {
        public int[] newList = new int[0];

        public void Add(int number)
        {
            int[] newArray = new int[newList.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < newList.Length)
                {
                    newArray[i] = newList[i];
                }
                else
                {
                    newArray[i] = number;
                }
            }
            newList = newArray;
        }
        public void Insert(int index, int number)
        {
            int[] newArray = new int[newList.Length + 1];

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = number;
                }
                else if (i != index)
                {
                    newArray[i] = newList[j];
                    j++;
                }
                else
                {
                    newArray[i] = newList[i];
                }
            }

            newList = newArray;
        }

        public void Show()
        {
            foreach (var el in newList)
            {
                Console.WriteLine($"{el}");
            }
        }
    }
}
