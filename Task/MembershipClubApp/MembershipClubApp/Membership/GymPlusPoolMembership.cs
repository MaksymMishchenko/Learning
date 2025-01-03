namespace MembershipClubApp.Membership
{
    internal class GymPlusPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymPlusPoolMembership(decimal price)
        {
            _price = price;
            _name = "Gym + pool";
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
