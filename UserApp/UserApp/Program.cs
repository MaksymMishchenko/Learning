using UserApp.Entities;

namespace UserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {
                var userData = new UserData(db);
                userData.AddsUsers();
                var getUsers = userData.GetUsers();

                var print = new PrintConsole();
                print.PrintUsers(getUsers);
            }
        }
    }
}
