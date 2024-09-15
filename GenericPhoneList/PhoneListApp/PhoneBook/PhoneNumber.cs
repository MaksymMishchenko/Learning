namespace PhoneListApp.PhoneBook
{
    internal class PhoneNumber
    {
        public PhoneNumber(string number, string name)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
