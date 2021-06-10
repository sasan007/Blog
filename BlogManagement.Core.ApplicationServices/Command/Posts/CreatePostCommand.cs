using BlogManagement.Core.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Posts
{
    public class CreatePostCommand
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Content { get; set; }

        public Post ToPost() => new Post
        {
            Title = Title,
            Content = Content
        };

    }
}
