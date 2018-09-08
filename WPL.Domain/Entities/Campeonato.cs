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

        public IEnumerable<CampeonatoPlataforma> Plataformas { get; set; }
        public IEnumerable<CampeonatoEdicao> Edicoes { get; set; }

        public Campeonato(
            long idJogador,
            string nome,
            string nomeAbreviado,
            string imagemLogo,
            string imagemRegulamentoSugestao,
            CampeonatoTipoEnum tipoSugestao,
            Plataforma plataforma
            )
            :base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = nomeAbreviado;
            this.ImagemLogo = imagemLogo;
            this.ImagemRegulamentoSugestao = imagemRegulamentoSugestao;
            this.Status = StatusEnum.Ativo;
            this.TipoSugestao = tipoSugestao;
        }

    }
}
