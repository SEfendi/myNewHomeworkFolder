using ItBrains.DAL;
using ItBrains.Models;
using ItBrains.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
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
            HomeVM homeVM = new HomeVM
            {
                FeedBacks = _db.FeedBacks.ToList(),

                About = _db.Abouts.FirstOrDefault(),

                Blogs = _db.Blogs.ToList(),
            };

            return View(homeVM);
        }

        

        public IActionResult Error()
        {
            return View();
        }
    }
}
