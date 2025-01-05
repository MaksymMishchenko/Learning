﻿namespace BooksApp.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
