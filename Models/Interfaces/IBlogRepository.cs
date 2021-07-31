using System.Collections.Generic;

namespace MyCoreApplication.Models.Interfaces
{
    public interface IBlogRepository
    {
        IEnumerable<BlogPosts> GetAllPosts();

        BlogPosts GetPostById(int postId);

        bool AddPost(BlogPosts blogPost);
    }
}