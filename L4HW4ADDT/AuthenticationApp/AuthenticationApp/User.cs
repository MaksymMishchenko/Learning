using System;

namespace AuthenticationApp
{
    internal class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string pass)
        {
            Login = login;
            Password = pass;
        }
    }
}
