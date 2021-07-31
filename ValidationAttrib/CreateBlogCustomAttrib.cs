using System.ComponentModel.DataAnnotations;
using MyCoreApplication.Models;

namespace MyCoreApplication.ValidationAttrib
{
    public class CreateBlogCustomAttrib : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var blog = (BlogPosts)validationContext.ObjectInstance;

            if(blog.CategoryId == Category.Technology && (value == null 
                || ((string)value).Length <= 0))
            {
                return new ValidationResult("Description required for technical blog");
            }

            return ValidationResult.Success;
        }
    }
}