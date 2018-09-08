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

        public long CampeonatoEdicaoId { get; set; }
        public CampeonatoEdicao CampeonatoEdicao { get; set; }

        public IEnumerable<Jogo> Jogos { get; set; }

        public CampeonatoEdicaoFase(
            long idJogador,
            string nome,
            CampeonatoEdicao campeonatoEdicao
            )
            :base(idJogador)
        {
            this.Nome = nome;
            this.Status = StatusEnum.Ativo;
            this.CampeonatoEdicao = campeonatoEdicao;
        }
    }
}
