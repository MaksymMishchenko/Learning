﻿using MedPillCorporationApp.Models;

namespace MedPillCorporationApp.Interfaces
{
    public interface IPillRepository
    {
        IQueryable<Pill> Pills { get; }
        Pill this[int id] { get; }
    }
}
