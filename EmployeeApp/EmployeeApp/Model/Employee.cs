namespace EmployeeApp.Model
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public Company Company { get; set; }
    }
}
