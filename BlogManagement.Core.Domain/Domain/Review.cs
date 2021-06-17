using Golrang.Framework.Domain;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogManagement.Core.Domain.Domain
{
    public class Review : BaseEntity
    {
        public int PostId { get; set; }
        [JsonIgnoreAttribute]
        public virtual Post Post { get; set; }
    }
}
