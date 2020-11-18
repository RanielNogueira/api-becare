using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BecareUI.Models;
using BecareDomain.Service;

namespace BecareUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHospital HospitalRepo;

        public HomeController(ILogger<HomeController> logger, IHospital hospitalRepo)
        {
            _logger = logger;
            HospitalRepo = hospitalRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Hospitais()
        {
            try
            {
                var result = await HospitalRepo.GetSaoPaulo();
                return Ok(result.Take(150));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
