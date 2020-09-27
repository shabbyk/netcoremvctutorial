using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyCoreApplication.Models;
using MyCoreApplication.Models.Interfaces;
using MyCoreApplication.Models.Repo;

namespace MyCoreApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        private readonly IBlogRepository _blogRepo;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, IBlogRepository blogRepository)
        {
            _logger = logger;
            _config = config;
            _blogRepo = blogRepository;
        }

        public IActionResult Index()
        {
            //return _blogRepo.GetPostById(2).Title;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
