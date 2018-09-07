using System;

namespace WPL.Domain.Entities
{
    public class Time : _EntityBase
    {
        public Time()
        {

        }

        private string Nome { get; set; }
        private string NomeAbreviado { get; set; }
        private DateTime DataFundacao { get; set; }
        private string ImagemLogo { get; set; }

        private Plataforma Plataforma { get; set; }
        private TimeStatusEnum Status { get; set; }

        public Time(
            long idJogador,
            string nome,
            string nomeAbreviado,
            DateTime dataFundacao,
            string imagemLogo,
            Plataforma plataforma)
            :base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = nomeAbreviado;
            this.DataFundacao = dataFundacao;
            this.ImagemLogo = imagemLogo;
            this.Plataforma = plataforma;
            this.Status = TimeStatusEnum.Ativo;
        }
    }
}
