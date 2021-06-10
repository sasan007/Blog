using BlogManagement.Core.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Blogs
{
    public class CreateBlogCommand
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string EnName { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string Desciption { get; set; }

        public Blog ToBlog() => new Blog
        {
            Name = Name,
            Desciption = Desciption,
            EnName = EnName
        };

    }
}
