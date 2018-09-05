using System;

namespace WPL.Domain.Entities
{
    public class Time : _EntityBase
    {
        public Time()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public DateTime DataFundacao { get; set; }
        public string ImagemLogo { get; set; }
        public StatusEnum Status { get; set; }

        public Plataforma Plataforma { get; set; }
    }
}
