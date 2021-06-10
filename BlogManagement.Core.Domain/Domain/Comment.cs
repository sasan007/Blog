using Golrang.Framework.Domain;

namespace BlogManagement.Core.Domain.Domain
{
    public class Comment: BaseEntity
    {
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}
