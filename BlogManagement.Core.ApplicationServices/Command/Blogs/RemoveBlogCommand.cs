using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Blogs
{
    public class RemoveBlogCommand
    {
        [Required]
        public int Id { get; set; }

    }
}
