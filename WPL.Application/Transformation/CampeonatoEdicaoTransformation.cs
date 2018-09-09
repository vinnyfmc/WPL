using System;
using System.Collections.Generic;
using System.Text;
using WPL.Application.Models;
using WPL.Domain.Entities;

namespace WPL.Application.Transformation
{
    public class CampeonatoEdicaoTransformation
    {

        public static CampeonatoEdicaoModel CampeonatoEdicaoEmCampeonatoEdicaoModel(CampeonatoEdicao campeonatoEdicao)
        {
            return new CampeonatoEdicaoModel(
                string.Format("{0} - {1}", campeonatoEdicao.Campeonato.Nome, campeonatoEdicao.Nome),
                campeonatoEdicao.DataInicio,
                campeonatoEdicao.DataFim,
                campeonatoEdicao.ImagemLogo,
                campeonatoEdicao.ImagemBanner,
                campeonatoEdicao.ImagemPremiacao,
                campeonatoEdicao.ImagemRegulamento,
                campeonatoEdicao.Tipo,
                campeonatoEdicao.Campeonato.Plataforma.ImagemLogo,
                campeonatoEdicao.Campeonato.Plataforma.NomeAbreviado,
                campeonatoEdicao.Campeonato.Plataforma.PlataformaDefault
                );
        }

        public static IEnumerable<CampeonatoEdicaoModel> CampeonatoEdicaoEmCampeonatoEdicaoModel(IEnumerable<CampeonatoEdicao> campeonatoEdicoes)
        {
            foreach (CampeonatoEdicao campeonatoEdicao in campeonatoEdicoes)
            {
                yield return CampeonatoEdicaoEmCampeonatoEdicaoModel(campeonatoEdicao);
            }
        }

    }
}
