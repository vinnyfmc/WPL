using WPL.Data.Context;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Data.Repositories
{
    public class JogadorSenhaRepository : RepositoryBase<JogadorSenha>, IJogadorSenhaRepository
    {
        WPLContext ctx;
        public JogadorSenhaRepository(WPLContext ctx)
            : base(ctx)
        {
            this.ctx = ctx;
        }
    }
}
