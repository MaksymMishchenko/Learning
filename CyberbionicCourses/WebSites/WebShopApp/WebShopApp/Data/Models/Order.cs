using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebShopApp.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Input name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Minimum character length - 20 characters")]
        public string Name { get; set; }

        [Display(Name = "Input surname")]
        [StringLength(20)]
        [Required(ErrorMessage = "Minimum character length - 20 characters")]
        public string Surname { get; set; }

        [Display(Name = "Input address")]
        [StringLength(35)]
        [Required(ErrorMessage = "Minimum character length - 35 characters")]
        public string Address { get; set; }

        [Display(Name = "Input phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Minimum character length - 20 characters")]
        public string Phone { get; set; }

        [Display(Name = "Input email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Minimum character length - 20 characters")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }

}
