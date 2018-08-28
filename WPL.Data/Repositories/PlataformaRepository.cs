using System;
using System.Collections.Generic;
using System.Text;
using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class PlataformaRepository : RepositoryBase<Plataforma>, IPlataformaRepository
    {
        WPLContext ctx;
        public PlataformaRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
