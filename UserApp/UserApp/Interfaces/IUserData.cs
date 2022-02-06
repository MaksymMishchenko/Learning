using System.Collections.Generic;

namespace UserApp.Interfaces
{
    interface IUserData
    {
        void AddsUsers();
        void UpdateUsers();
        void DeleteUsers();
        IEnumerable<User> GetUsers();
    }
}
