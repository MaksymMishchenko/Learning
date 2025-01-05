using System;
using System.Collections.Generic;

namespace SocialNetworksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkService netService = new();
            var socialNetworksList = netService.AddSocialNetwork();
            ShowSocialNetworks(socialNetworksList);
        }

        static void ShowSocialNetworks(IEnumerable<string> socialNetworks)
        {
            Console.WriteLine("Social Networks: ");
            foreach (var item in socialNetworks)
            {
                Console.WriteLine($"\t\t{item}");
            }
        }
    }
}
