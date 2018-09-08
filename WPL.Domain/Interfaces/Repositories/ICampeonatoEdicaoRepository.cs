using System.Collections.Generic;
using WPL.Domain.Entities;

namespace WPL.Domain.Interfaces.Repositories
{
    public interface ICampeonatoEdicaoRepository : IRepositoryBase<CampeonatoEdicao>
    {
        CampeonatoEdicao GetUltimoCampeonatoPorPlataforma(long idPlataforma);
    }
}
