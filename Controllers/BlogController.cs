using Microsoft.AspNetCore.Mvc;
using MyCoreApplication.Models;
using MyCoreApplication.Models.Interfaces;

namespace MyCoreApplication.Controllers
{
    [Route("[controller]/[action]")]
    public class BlogController :  Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        [Route("")]
        [Route("~/")]
        [Route("~/Blog")]
        public IActionResult Index()
        {
            var blog =  _blogRepository.GetAllPosts();

            return View(blog);
        }

        [Route("{id}")]
        public IActionResult GetPost(int id)
        {
            var blog = _blogRepository.GetPostById(id);
            return View(blog);
        }
    }
}