using System;
using System.Collections.Generic;
using System.Linq;
using MyCoreApplication.Models.Interfaces;

namespace MyCoreApplication.Models.Repo
{
    public class BlogRepository : IBlogRepository
    {
        private List<BlogPosts> _posts;
        public BlogRepository()
        {
            _posts = new List<BlogPosts>() 
            {
                new BlogPosts
                {
                    PostId = 1,
                    Title = "My first Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                },
                new BlogPosts
                {
                    PostId = 2,
                    Title = "My Second Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                },
                new BlogPosts
                {
                    PostId = 3,
                    Title = "My Third Blog",
                    Description = "Blog to show off models",
                    CreatedOn = DateTime.Now
                }
            };
        }

        public bool AddBlog(BlogPosts blog)
        {
            blog.PostId = _posts.Max(x => x.PostId) + 1;
            blog.CreatedOn = DateTime.Now;

            _posts.Add(blog);
            return true;
        }

        public IEnumerable<BlogPosts> GetAllPosts()
        {
            return _posts;
        }

        public BlogPosts GetPostById(int postId)
        {
            return _posts.FirstOrDefault(x => x.PostId == postId);
        }
    }
}