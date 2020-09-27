using Microsoft.AspNetCore.Mvc;
using MyCoreApplication.Models;
using MyCoreApplication.Models.Interfaces;

namespace MyCoreApplication.Controllers
{
    public class BlogController :  Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        public IActionResult Index()
        {
            BlogPosts blog =  _blogRepository.GetPostById(2);

            ViewData["Title"] = "Title of my blog";
            ViewData["BlogData"] = blog;

            ViewBag.ViewbagData = blog;

            return View();
        }
    }
}