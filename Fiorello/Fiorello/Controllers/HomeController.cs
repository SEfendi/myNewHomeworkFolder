using Fiorello.DAL;
using Fiorello.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVm homeVM = new HomeVm
            {
                SliderImages = _db.SliderImages.ToList(),
                SliderContext = _db.SliderContext.FirstOrDefault(),
                Experts = _db.Experts.ToList(),
            };

            return View(homeVM);
        }

        

        public IActionResult Error()
        {
            return View();
        }
    }
}
