﻿using BlogManagement.Core.Domain.Domain;
using BlogManagement.Core.Domain.Repository;
using BlogManagement.Infra.Data.Sql.Context;
using Golrang.Framework.Infra;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infra.Data.Sql.Implementation
{
    public class EfCommentRepository : EFRepository<Comment>, CommentRepository
    {
        public EfCommentRepository(EFDbContext context) : base(context)
        {
        }
    }
}
