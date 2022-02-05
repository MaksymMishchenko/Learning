using System.Collections.Generic;

namespace UserApp.Interfaces
{
    interface IUserData
    {
        void AddsUsers();
        IEnumerable<User> GetUsers();
    }
}
