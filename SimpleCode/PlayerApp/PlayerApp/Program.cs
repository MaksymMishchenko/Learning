using System;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] arsenal = { new Bow(), new Gun(), new SubMachineGum()};
            ShowArsenal(player, arsenal);
        }

        static void ShowArsenal(Player player, Weapon[] arsenal)
        {
            foreach (var item in arsenal)
            {
                item.ShowInfo();
                item.Fire();
                Console.WriteLine();
            }
        }
    }
}
