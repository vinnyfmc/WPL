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

        public void Atualizar(TEntity obj)
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

        public void Incluir(TEntity obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(obj);
            ctx.SaveChanges();
        }

        public TEntity ObterPorId(long id)
        {
            return entities.Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return entities.AsEnumerable();
        }

        public void Remover(TEntity obj)
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
