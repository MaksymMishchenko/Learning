using System;
using System.Collections.Generic;
using System.Linq;
using UserApp.Interfaces;

namespace UserApp.Entities
{
    class UserData : IUserData
    {
        private DbContent _dbContent;
        private IEnumerable<User> _user;

        public UserData(DbContent dbContent)
        {
            _dbContent = dbContent;
            _user = new List<User>();
        }

        public void AddsUsers()
        {
            using (var db = new DbContent())
            {
                if (!db.Users.Any())
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

        public void UpdateUsers()
        {
            using (var db = new DbContent())
            {
                User user = _dbContent.Users.FirstOrDefault();

                user.Name = "Fetil";
                user.Age = 25;

                db.Users.Update(user);
                db.SaveChanges();
            }
        }

        public void DeleteUsers()
        {
            using (var db = new DbContent())
            {
                User user = _dbContent.Users.FirstOrDefault();

                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }
        }

        public IEnumerable<User> GetUsers()
        {
            if (!_user.Any())
            {
                _user = _dbContent.Users;
            }

            return _user.ToList();
        }
    }
}
