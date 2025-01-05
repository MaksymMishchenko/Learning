using MembershipClubApp.Membership;

namespace MembershipClubApp.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
