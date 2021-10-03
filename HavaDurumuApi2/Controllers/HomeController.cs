using HavaDurumu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HavaDurumuApi2;
using HavaDurumuApi2.Models;
using Microsoft.AspNetCore.Http;

namespace HavaDurumu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Data> HavaDurumlari;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HavaDurumlari =  ListData.getHavaDurumu();
            ViewBag.HDL = HavaDurumlari;
            return View(HavaDurumlari);
        }
        [HttpPost]
        public IActionResult Index(string search)
        {
           
            search = Request.Form["Hava Durumu"].ToString();
            HavaDurumlari = ListData.getHavaDurumu().Where(m => m.Sehir == search).ToList();
           
            return View(HavaDurumlari);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
