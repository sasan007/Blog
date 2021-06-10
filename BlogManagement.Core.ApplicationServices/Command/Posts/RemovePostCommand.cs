using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Posts
{
    public class RemovePostCommand
    {
        [Required]
        public int Id { get; set; }

    }
}
