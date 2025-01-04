namespace PersonDataApp.Model
{
    class Person
    {
        public Person(string surname, string name, string address, string city)
        {
            Surname = surname;
            Name = name;
            Address = address;
            City = city;
        }

        public string Surname { get; }
        public string Name { get; }
        public string Address { get; }
        public string City { get; }
    }
}

