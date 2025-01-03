namespace CustomersApp
{
    internal class Customer
    {
        public string LastName { get; set; }

        public Customer(string lastName)
        {
            LastName = lastName;
        }
    }
}