using MembershipClubApp.Factories;
using MembershipClubApp.Membership;
using System;

namespace MembershipClubApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Welcome to Membership Club <<<");
            Console.WriteLine("Choose your membership you would like to buy?");

            Console.WriteLine("'G' - Gym Membership");
            Console.WriteLine("'P' - Gym Membership");
            Console.WriteLine("'T' - Gym Membership");

            string membershipTape = Console.ReadLine();

            MembershipFactory factory = GetFactory(membershipTape);
            IMembership membership = factory.GetMembership();

            Console.WriteLine("\nMembership you've just created:\n");

            Console.WriteLine($"\tName:\t\t{membership.Name}\n" +
                              $"\tDescription:\t{membership.Description}\n" +
                              $"\tPrice:\t\t{membership.GetPrice()}");
        }

        public static MembershipFactory GetFactory(string membershipTape) =>
            membershipTape.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Basic mebership"),
                "p" => new GymPlusPoolMembershipFactory(250, "Gym + Pool membership"),
                "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
                _ => null
            };
    }
}
