using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class TimeJogadorRepository : RepositoryBase<TimeJogador>, ITimeJogadorRepository
    {
        WPLContext ctx;
        public TimeJogadorRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
