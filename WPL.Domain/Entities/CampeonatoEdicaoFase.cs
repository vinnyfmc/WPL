using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class CampeonatoEdicaoFase : _EntityBase
    {
        public CampeonatoEdicaoFase()
        {

        }

        public string Nome { get; set; }
        public StatusEnum Status { get; set; }

        public CampeonatoEdicao Edicao { get; set; }

        public IEnumerable<Jogo> Jogos { get; set; }
    }
}
