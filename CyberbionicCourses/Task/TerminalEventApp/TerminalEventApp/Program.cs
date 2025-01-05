using System;

namespace TerminalEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new object Terminal
            var terminal = new Terminal(1000.00M);
            Console.WriteLine("Денег на счету: ");
            terminal.ShowBill();

            //sign PutsMoney method to event
            terminal.PutMoney += terminal.PutsMoney;
            terminal.PutMoneyInvoke(100.00m);
            Console.WriteLine("Денег на счету, после того, как положили: ");
            terminal.ShowBill();

            //sign WithdrawsMoney method to event
            terminal.GetMoney += terminal.WithdrawsMoney;
            terminal.GetMoneyInvoke(600.00m);
            Console.WriteLine("Денег на счету, после того, как сняли: ");
            terminal.ShowBill();
        }
    }
}
