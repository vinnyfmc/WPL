using System.Linq;
using WPL.Data.Context;
using WPL.Domain;
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

        public CampeonatoEdicao GetUltimoCampeonatoPorPlataforma(long idPlataforma)
        {

            var query = (from a in ctx.CampeonatoEdicao
                         join b in ctx.Campeonato on a.CampeonatoId equals b.Id
                         where b.PlataformaId == idPlataforma && a.DataExclusao == null && a.Status == CampeonatoStatusEnum.AguardandoInicio && b.Status == StatusEnum.Ativo
                         select a
                         ).ToList();

            return query.OrderByDescending(x => x.Id).FirstOrDefault();
        }
    }
}
