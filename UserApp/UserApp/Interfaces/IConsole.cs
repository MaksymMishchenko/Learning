using System.Collections.Generic;

namespace UserApp.Entities
{
    interface IConsole
    {
        void PrintUsers(IEnumerable<User> users);
    }
}
