using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AuthenticationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<User>();

            TryAgain:
            Console.WriteLine("Welcome to our community. Please register.");
            Console.WriteLine("Input your login: [use only a-z A-Z]\n");
            string login = Console.ReadLine();

            Console.WriteLine("Input your password: [use only a-z A-Z 0-9]\n");
            string password = Console.ReadLine();

            string loginPattern = @"^[a-zA-Z]+$";
            string passPattern = @"^[a-zA-Z0-9]+$";

            var checkLogin = new Regex(loginPattern);
            var checkPass = new Regex(passPattern);


            if (checkLogin.IsMatch(login) && checkPass.IsMatch(password))
            {
                list.Add(new User(login, password));
                Console.WriteLine("Registration is successful!");
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again");
                goto TryAgain;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id}, {item.Login}, {item.Password}");
            }
        }
    }
}
