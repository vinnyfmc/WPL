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
        private string Logo { get; set; }

        private Plataforma Plataforma { get; set; }
        private StatusEnum Status { get; set; }
    }
}
