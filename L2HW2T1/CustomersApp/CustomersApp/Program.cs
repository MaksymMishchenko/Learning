using System;
using System.Collections.Generic;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coll = new Dictionary<Customer, List<Category>>();
            coll.Add(new Customer("Mischenko"), new List<Category> { Category.BakeryProducts, Category.Fish});
            coll.Add(new Customer("Bogaychuk"), new List<Category> { Category.Office});
            coll.Add(new Customer("Pruymyk"), new List<Category> { Category.Office, Category.BakeryProducts, Category.Fish});

            foreach (var item in coll)
            {
                Console.WriteLine($"Customer: {item.Key.LastName}");

                foreach (var category in item.Value)
                {
                    Console.WriteLine($"\tCategory: {category}");
                }
            }

            Console.WriteLine(new string('-', 30));

            var getCustomerByCategory = GetCustomerByCategory(coll, Category.BakeryProducts);
            
            foreach (var customer in getCustomerByCategory)
            {
                Console.WriteLine($"Name: {customer.LastName}"); 
            }
        }

        private static List<Customer> GetCustomerByCategory(Dictionary<Customer, List<Category>> coll, Category category)
        {
            var customer = new List<Customer>();

            foreach (var item in coll)
            {
                if (item.Value.Contains(category))
                {
                    customer.Add(item.Key);
                }
            }

            return customer;
        }
    }
}
