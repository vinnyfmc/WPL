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

        public CampeonatoEdicaoFase(
            long idJogador,
            string nome,
            CampeonatoEdicao edicao
            )
            :base(idJogador)
        {
            this.Nome = nome;
            this.Status = StatusEnum.Ativo;
            this.Edicao = edicao;
        }
    }
}
