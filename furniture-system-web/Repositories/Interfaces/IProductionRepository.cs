﻿using furniture_system_web.Model;
using System.Threading.Tasks;

namespace furniture_system_web.Repositories.Logics
{
    public interface IProductionRepository
    {
        Task<bool> SaveBill(ProductionVM model);
    }
}