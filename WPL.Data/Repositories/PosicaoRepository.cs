using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class PosicaoRepository : RepositoryBase<Posicao>, IPosicaoRepository
    {
        WPLContext ctx;
        public PosicaoRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
