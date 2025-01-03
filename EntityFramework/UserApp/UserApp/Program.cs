using System;
using UserApp.Entities;

namespace UserApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var userData = new UserData(new DbContent());
            userData.AddsUsers();
            var getUsers = userData.GetUsers();

            var printAdd = new PrintConsole();
           printAdd.PrintUsers(getUsers);

            Console.WriteLine(new string('-', 20));
            
            userData.UpdateUsers();
            Console.WriteLine("Users after update: ");
            printAdd.PrintUsers(getUsers);
            
            Console.WriteLine(new string('-', 20));
            
            userData.DeleteUsers();
            Console.WriteLine("Users after deletion: ");
            printAdd.PrintUsers(getUsers);
        }
    }
}
