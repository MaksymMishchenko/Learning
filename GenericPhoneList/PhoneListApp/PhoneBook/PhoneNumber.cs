namespace PhoneListApp.PhoneBook
{
    internal class PhoneNumber
    {
        public PhoneNumber(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
