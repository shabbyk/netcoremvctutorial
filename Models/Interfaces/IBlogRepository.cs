namespace MyCoreApplication.Models.Interfaces
{
    public interface IBlogRepository
    {
        BlogPosts GetPostById(int postId);
    }
}