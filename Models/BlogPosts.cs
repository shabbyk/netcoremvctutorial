using System;

namespace MyCoreApplication.Models
{
    public class BlogPosts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
