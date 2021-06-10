using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Core.ApplicationServices.Command.Comments
{
    public class RemoveCommentCommand
    {
        [Required]
        public int Id { get; set; }

    }
}
