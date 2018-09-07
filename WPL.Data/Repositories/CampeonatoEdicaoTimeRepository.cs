using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class CampeonatoEdicaoTimeRepository : RepositoryBase<CampeonatoEdicaoTime>, ICampeonatoEdicaoTimeRepository
    {
        WPLContext ctx;
        public CampeonatoEdicaoTimeRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
