﻿using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class SettingController : Controller
    {
        private readonly ISettingService service;

        public SettingController(ISettingService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(await this.service.GetAsync());
        }
    }
}