using System;
using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class CampeonatoEdicao : _EntityBase
    {
        public CampeonatoEdicao()
        {

        }

        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string ImagemLogo { get; set; }
        public string ImagemPremiacao { get; set; }
        public string ImagemRegulamento { get; set; }
        public CampeonatoStatusEnum Status { get; set; }
        public CampeonatoTipoEnum Tipo { get; set; }

        public IEnumerable<CampeonatoEdicaoFase> Fases { get; set; }
        public IEnumerable<CampeonatoEdicaoTime> Times { get; set; }
    }
}
