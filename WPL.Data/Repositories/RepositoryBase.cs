using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WPL.Data.Context;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly WPLContext ctx;
        private DbSet<TEntity> entities;

        public RepositoryBase(WPLContext ctx)
        {
            this.ctx = ctx;
            entities = ctx.Set<TEntity>();
        }

        public void Update(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("entity");
            }
            ctx.Entry(obj).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Dispose()
        {
        }

        public void Add(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(obj);
            ctx.SaveChanges();
        }

        public TEntity GetById(long id)
        {
            return entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Remove(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(obj);
            ctx.SaveChanges();
        }
    }
}
