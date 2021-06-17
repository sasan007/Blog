using Golrang.Framework.Domain;
using System.Collections.Generic;

namespace BlogManagement.Core.Domain.Domain
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string EnName { get; set; }
        public string Desciption { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
