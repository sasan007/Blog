﻿using Golrang.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Golrang.Framework.Infra
{
    public class EFRepository<T> : BaseRepository<T> where T : BaseEntity, new()
    {
        protected DbContext _context;
        private DbSet<T> entities;
        public EFRepository(DbContext context)
        {
            _context = context;
        }
        private DbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = _context.Set<T>();
                }
                return entities;
            }
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            _context.Add(entity);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return entities.Find(id);
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            Entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            T entity = new T()
            {
                Id=id
            };
            _context.Set<T>().Remove(entity);
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
