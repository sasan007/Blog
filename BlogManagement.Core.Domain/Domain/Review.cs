using Golrang.Framework.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Domain
{
    public class Review : BaseEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
