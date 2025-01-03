namespace MembershipClubApp.Membership
{
    internal class PersonalTrainingMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public PersonalTrainingMembership(decimal price)
        {
            _price = price;
            _name = "Personal Training";
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
