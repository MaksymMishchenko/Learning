using System.Collections.Generic;

namespace SocialNetworksApp
{
    internal class NetworkService
    {
        public LinkedList<string> AddSocialNetwork()
        {
            string[] array = { "Instagram", "FaceBook", "Tik-Tok" };
            LinkedList<string> socialNetworks = new LinkedList<string>(array);
            socialNetworks.AddFirst("Twitter");
            socialNetworks.AddLast("Tumblr");
            socialNetworks.AddBefore(socialNetworks.Find("Tumblr"), "LinkedIn");
            socialNetworks.AddAfter(socialNetworks.Find("Tumblr"), "Pinterest");
            return socialNetworks;
        }
    }
}
