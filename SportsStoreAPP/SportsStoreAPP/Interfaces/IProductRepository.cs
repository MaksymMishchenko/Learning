﻿using SportsStoreAPP.Models;

namespace SportsStoreAPP.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
