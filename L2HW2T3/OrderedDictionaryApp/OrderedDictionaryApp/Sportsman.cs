namespace OrderedDictionaryApp
{
    internal class Sportsman
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public string Hobbies { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {Name}, Hobbies: {Hobbies}").ToString();
        }
    }
}