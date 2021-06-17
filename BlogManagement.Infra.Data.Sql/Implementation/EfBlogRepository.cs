using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using Golrang.Framework.Infra;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfBlogRepository : EFRepository<Blog>, BlogRepository
    {
        public EfBlogRepository(EFDbContext context) : base(context)
        {
        }
    }
}
