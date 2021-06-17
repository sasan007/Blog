using BlogManagement.Core.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Posts
{
    public class CreateReviewCommand
    {
        public CreateReviewCommand(int postId)
        {
            PostId = postId;
        }
        public int PostId { get; set; }
        public Review ToReview() => new Review
        {
            PostId = PostId
        };
    }
}
