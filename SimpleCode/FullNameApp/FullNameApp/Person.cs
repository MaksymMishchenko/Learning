namespace FullNameApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }

        public string GetFulName()
        {
            return $"Фамилия: {SecondName ?? "Нет данных!"} | Имя:  {FirstName ?? "Нет данных!"} | Отчество: {MiddleName ?? "Нет данных!"}";
        }
    }
}
