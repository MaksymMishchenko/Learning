﻿using System.ComponentModel.DataAnnotations;

namespace SportsStoreAPP.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter a correct name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please, enter a description")]
        public string? Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Please, specify a category")]
        public string? Category { get; set; }
    }
}
