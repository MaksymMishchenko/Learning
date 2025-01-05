using MembershipClubApp.Membership;

namespace MembershipClubApp.Factories
{
    class PersonalTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public PersonalTrainingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            PersonalTrainingMembership personalTrainingMembership = new PersonalTrainingMembership(_price)
            {
                Description = _description
            };
            return personalTrainingMembership;
        }
    }
}
