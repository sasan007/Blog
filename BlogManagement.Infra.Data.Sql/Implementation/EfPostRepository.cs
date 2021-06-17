using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using Golrang.Framework.Infra;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfPostRepository : EFRepository<Post>, PostRepository
    {
        public EfPostRepository(EFDbContext context) : base(context)
        {
        }
    }
}
