using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class JogoJogadorRepository : RepositoryBase<JogoJogador>, IJogoJogadorRepository
    {
        WPLContext ctx;
        public JogoJogadorRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}