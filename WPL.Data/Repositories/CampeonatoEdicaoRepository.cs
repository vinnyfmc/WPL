using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class CampeonatoEdicaoRepository : RepositoryBase<CampeonatoEdicao>, ICampeonatoEdicaoRepository
    {
        WPLContext ctx;
        public CampeonatoEdicaoRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
