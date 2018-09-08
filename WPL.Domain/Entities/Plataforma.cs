using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class Plataforma : _EntityBase
    {
        public Plataforma()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string ImagemLogo { get; set; }
        public bool PlataformaDefault { get; set; }
        public StatusEnum Status { get; set; }

        public IEnumerable<CampeonatoPlataforma> Campeonatos { get; set; }
        public IEnumerable<Jogador> Jogadores { get; set; }
        public IEnumerable<Time> Times { get; set; }

        public Plataforma(
            long idJogador, 
            string nome, 
            string nomeAbrevado, 
            string imagemLogo,
            bool plataformaDefault)
            : base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = nomeAbrevado;
            this.ImagemLogo = imagemLogo;
            this.PlataformaDefault = plataformaDefault;
            this.Status = StatusEnum.Ativo;
        }
    }
}
