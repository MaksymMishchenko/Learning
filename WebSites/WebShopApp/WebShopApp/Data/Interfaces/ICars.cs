using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavouriteCars { get; set; }
        Car GetCar(int carId);
    }
}
