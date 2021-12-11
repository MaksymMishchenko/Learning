using System;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] arsenal = { new Bow(), new Gun(), new SubMachineGun(), new Knife()};
            ShowArsenal(player, arsenal);
        }

        static void ShowArsenal(Player player, IWeapon[] arsenal)
        {
            foreach (var item in arsenal)
            {
                item.ShowInfo();
                item.Fire();
                Console.WriteLine();
            }
            player.ShowInfo(new Knife());
            player.Throw(new Knife());
        }
    }
}
