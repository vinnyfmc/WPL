using System.Collections.Generic;
using WPL.Application.Models;

namespace WPL.Application.Services
{
    public interface ICampeonatoEdicaoAppService
    {
        IEnumerable<CampeonatoEdicaoModel> GetUltimaEdicaoPorPlataformas();
    }
}
