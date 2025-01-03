using System;
namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] arsenal = { new Bow(), new Gun(), new SubMachineGun(), new Knife()};

            IConsole showToConsole = new Console();
            showToConsole.ShowInformationToConsole(player, arsenal);
        }
    }
}
