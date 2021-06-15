using Golrang.Framework.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Domain
{
    public class Post: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments{ get; set; }
        public List<Review> Reviews { get; set; }
    }
}
