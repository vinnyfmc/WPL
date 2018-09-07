using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class JogadorStatusHistoricoRepository : RepositoryBase<JogadorStatusHistorico>, IJogadorStatusHistoricoRepository
    {
        WPLContext ctx;
        public JogadorStatusHistoricoRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}