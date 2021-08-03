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
            var blog =  _blogRepository.GetAllPosts();

            return View(blog);
        }

        public IActionResult GetPost(int id)
        {
            var blog = _blogRepository.GetPostById(id);
            return View(blog);
        }

        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(BlogPosts post)
        {
            _blogRepository.AddBlog(post);
            return RedirectToAction("GetPost", new { id = post.PostId});
        }
    }
}