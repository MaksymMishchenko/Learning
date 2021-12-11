using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    interface IConsole
    {
        void ShowInformationToConsole(Player player, IWeapon[] weapon);
    }

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
