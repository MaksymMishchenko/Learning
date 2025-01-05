namespace PhoneListApp.PhoneBook
{
    internal class Friend : IPhoneNumber
    {
        public Friend(string name, string number, bool isWn)
        {
            IsWorkNumber = isWn;
            Name = name;
            Number = number;
        }

        public bool IsWorkNumber { get; private set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
