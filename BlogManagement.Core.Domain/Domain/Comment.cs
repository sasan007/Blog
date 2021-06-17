using Golrang.Framework.Domain;
using System.Text.Json.Serialization;

namespace BlogManagement.Core.Domain.Domain
{
    public class Comment: BaseEntity
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        [JsonIgnoreAttribute]
        public virtual Post Post { get; set; }
    }
}
