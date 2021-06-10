using BlogManagement.Core.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Posts
{
    public class UpdatePostCommand
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Content { get; set; }

        public Post ToPost() => new Post
        {
            Id = Id,
            Title = Title,
            Content = Content
        };

    }
}
