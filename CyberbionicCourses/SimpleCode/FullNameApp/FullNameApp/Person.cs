namespace FullNameApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"Фамилия: {SecondName ?? "Нет данных!"} | Имя:  {FirstName ?? "Нет данных!"} | Отчество: {MiddleName ?? "Нет данных!"}";
        }

        public string GetPhoneNumber()
        {
            return $"Телефон: {Contacts?.PhoneNumber ?? "Нет данных"}";
        }
    }
}
