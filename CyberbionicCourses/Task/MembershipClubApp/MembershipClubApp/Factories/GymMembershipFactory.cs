using MembershipClubApp.Membership;

namespace MembershipClubApp.Factories
{
    class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymMembership gymMembershipFactory = new GymMembership(_price)
            {
                Description = _description
            };
            return gymMembershipFactory;
        }
    }
}
