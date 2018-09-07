using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class JogoTimeRepository : RepositoryBase<JogoTime>, IJogoTimeRepository
    {
        WPLContext ctx;
        public JogoTimeRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}