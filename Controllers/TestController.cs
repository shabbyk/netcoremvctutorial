using Microsoft.AspNetCore.Mvc;
using MyCoreApplication.Models;

namespace MyCoreApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public bool CreatePost(BlogPosts blogPost)
        {
            // Some code to add blog post
            return true;
        }
    }
}