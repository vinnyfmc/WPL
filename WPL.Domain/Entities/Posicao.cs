using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class Posicao : _EntityBase
    {
        public Posicao()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string Logo { get; set; }
        public StatusEnum Status { get; set; }

        public virtual ICollection<Jogador> Jogadores { get; set; }
        public virtual ICollection<JogoJogador> JogoJogadores { get; set; }
        public virtual ICollection<TimeJogador> TimeJogadores { get; set; }

        public Posicao(
            long idJogador, 
            string nome, 
            string nomeAbreviado, 
            string logo)
            : base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = NomeAbreviado;
            this.Logo = logo;
            this.Status = StatusEnum.Ativo;
        }

    }
}
