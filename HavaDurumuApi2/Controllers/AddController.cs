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

namespace HavaDurumuApi2.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Data data)
        {
            HavaDurumuApi2.ListData.addHavaDurumu(data);
            return (RedirectToAction("Index","Home"));
        }
    }
}
