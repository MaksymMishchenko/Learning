namespace MyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(4);

            var myListStr = new MyList<string>();
            myListStr.Add("Hello");
            myListStr.Add("World");
            myListStr.Show();
            
            myList.Insert(1, 2);
            myList.Insert(4, 5);
            myList.Show();
        }
    }
}
