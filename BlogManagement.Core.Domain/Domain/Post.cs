using Golrang.Framework.Domain;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogManagement.Core.Domain.Domain
{
    public class Post: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        [JsonIgnoreAttribute]
        public Blog Blog { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
