using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class Campeonato : _EntityBase
    {
        public Campeonato()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string ImagemLogo { get; set; }
        public string ImagemRegulamentoSugestao { get; set; }
        public StatusEnum Status { get; set; }
        public CampeonatoTipoEnum TipoSugestao { get; set; }

        public Plataforma Plataforma { get; set; }

        public IEnumerable<CampeonatoEdicao> Edicoes { get; set; }
    }
}
