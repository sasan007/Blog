using System.ComponentModel.DataAnnotations;

namespace Golrang.Framework.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
