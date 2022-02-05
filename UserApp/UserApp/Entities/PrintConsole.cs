using System;
using System.Collections.Generic;

namespace UserApp.Entities
{
    class PrintConsole: IConsole
    {
        public void PrintUsers(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name} | Age: {user.Age}");
            }
        }
    }
}
