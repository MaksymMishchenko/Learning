using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavouriteCars { get; }
        Car GetCar(int carId);
    }
}
