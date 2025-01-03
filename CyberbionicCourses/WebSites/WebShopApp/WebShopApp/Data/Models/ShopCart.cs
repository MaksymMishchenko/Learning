using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebShopApp.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContent _appDbContent;

        public string ShopCartId { get; set; }

        public List<ShopCartItem> ListShopItems { get; set; }

        public ShopCart(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Car = car,
                Price = car.Price
            });

            _appDbContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDbContent.ShopCartItem
                .Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.Car)
                .ToList();
        }
    }
}
