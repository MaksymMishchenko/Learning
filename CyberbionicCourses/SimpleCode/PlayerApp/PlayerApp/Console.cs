using System;

namespace PlayerApp
{
    class Console : IConsole
    {
        public void ShowInformationToConsole(Player player, IWeapon[] weapon)
        {
            foreach (var item in weapon)
            {
                item.ShowInfo();
                item.Fire();
                System.Console.WriteLine();
            }
            player.ShowInfo(new Knife());
            player.Throw(new Knife());
        }
    }
}
