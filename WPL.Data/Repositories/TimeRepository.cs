using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class TimeRepository : RepositoryBase<Time>, ITimeRepository
    {
        WPLContext ctx;
        public TimeRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
