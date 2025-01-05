namespace PhoneListApp.PhoneBook
{
    internal class Supplier : IPhoneNumber
    {
        public Supplier(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }
}
