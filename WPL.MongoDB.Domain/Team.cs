using System;
using System.Collections.Generic;
using static WPL.MongoDB.Domain.Enum;

namespace WPL.MongoDB.Domain
{
    public class Team
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string FotoUrl { get; set; }
        public DateTime DataFundacao { get; set; }
        public StatusEnum Status { get; set; }
        public ModalityEnum Modalidade { get; set; }
        public IList<Player> Jogadores { get; set; }
        public IList<Championship> Campeonatos { get; set; }
    }
}