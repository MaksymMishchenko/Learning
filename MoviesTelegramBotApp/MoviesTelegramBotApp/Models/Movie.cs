﻿namespace MoviesTelegramBotApp.Models
{
    internal class Movie
    {
        public int MovieId { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
        public decimal Budget { get; set; }
        public string? ImageUrl { get; set; }
        public string? MovieUrl { get; set; }
    }
}
