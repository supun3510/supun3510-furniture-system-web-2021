﻿using furniture_system_web.Model;
using furniture_system_web.Repositories;
using furniture_system_web.Repositories.Logics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furniture_system_web.Controllers
{
    [Route("api/Production")]
    [ApiController]
    public class ProductionController : ControllerBase
    {
        // GET: api/<CategoryController>
        private readonly IProductionRepository _productionRepo;
        private UserManager<ApplicationUser> _userManager;
        private readonly ApplicationSettings _appSettings;

        public ProductionController(UserManager<ApplicationUser> userManager, IOptions<ApplicationSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _userManager = userManager;
            _productionRepo = new ProductionRepository();
        }

        [HttpPost]
        [Route("SaveBill")]
        public async Task<bool> SaveBill(ProductionVM model)
        {
            try
            {
                    return await _productionRepo.SaveBill(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
