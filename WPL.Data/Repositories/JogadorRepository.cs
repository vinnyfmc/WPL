using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class JogadorRepository : RepositoryBase<Jogador>, IJogadorRepository
    {
        WPLContext ctx;
        public JogadorRepository(WPLContext ctx)
            :base(ctx)
        {
            this.ctx = ctx;
        }

        public Jogador ObterPorEmail(string email)
        {
            
            return ctx.Jogador.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}
