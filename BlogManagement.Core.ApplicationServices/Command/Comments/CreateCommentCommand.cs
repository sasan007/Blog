using BlogManagement.Core.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Comments
{
    public class CreateCommentCommand
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Text { get; set; }

        public Comment ToComment() => new Comment
        {
            Text = Text
        };

    }
}
