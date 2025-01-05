using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
