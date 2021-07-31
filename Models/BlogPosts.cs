using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyCoreApplication.ValidationAttrib;

namespace MyCoreApplication.Models
{
    public class BlogPosts : IValidatableObject
    {
        public int PostId { get; set; }

        // [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }

        [StringLength(20, ErrorMessage = "Should bot be more than 20 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Select a category")]
        public Category CategoryId { get; set; }

        [Required(ErrorMessage = "Select a category")]
        [EmailAddress(ErrorMessage = "Not a valid emiail")]
        public string Email { get; set; }

        [Range(1, 135, ErrorMessage = "Between 1 to 135")]
        public int Age { get; set; }

        public DateTime CreatedOn { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var blog = (BlogPosts)validationContext.ObjectInstance;

            if (blog.CategoryId == Category.Technology && (Description == null || Description.Length <= 0))
            {
                yield return new ValidationResult("Description required for technical blog",
                    new[] { nameof(Description) });
            }
        }
    }
}
