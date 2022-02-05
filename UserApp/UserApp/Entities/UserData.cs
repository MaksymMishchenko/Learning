using System;
using System.Collections.Generic;
using System.Linq;
using UserApp.Interfaces;

namespace UserApp.Entities
{
    class UserData : IUserData
    {
        private DbContent _dBContent;
        private IEnumerable<User> _users;

        public UserData(DbContent dBContent)
        {
            _dBContent = dBContent;
        }

        public void AddsUsers()
        {
            using (var db = new DbContent())
            {
                if (!_dBContent.Users.Any())
                {
                    User maks = new User { Name = "Nadin", Age = 32 };

                    User artur = new User { Name = "Artur", Age = 21 };

                    User sveta = new User { Name = "Sveta", Age = 25 };

                    db.Users.AddRange(maks, artur, sveta);
                }
               
                db.SaveChanges();
                Console.WriteLine("Data added successfully!");
            }
        }

        public IEnumerable<User> GetUsers() => _dBContent.Users;
    }
}
