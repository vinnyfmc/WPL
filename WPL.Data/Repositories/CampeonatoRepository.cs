using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class CampeonatoRepository : RepositoryBase<Campeonato>, ICampeonatoRepository
    {
        WPLContext ctx;
        public CampeonatoRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }

    }
}
