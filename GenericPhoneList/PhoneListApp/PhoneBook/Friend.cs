namespace PhoneListApp.PhoneBook
{
    internal class Friend : PhoneNumber
    {
        public Friend(string name, string number, bool isWn) : base(name, number) { }

        public bool IsWorkNumber { get; private set; }
    }
}
