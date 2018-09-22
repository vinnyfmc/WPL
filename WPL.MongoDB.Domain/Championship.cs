using System.Collections.Generic;
using static WPL.MongoDB.Domain.Enum;

namespace WPL.MongoDB.Domain
{
    public class Championship
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string FotoUrl { get; set; }
        public string Regulamento { get; set; }
        public string FotoPremioUrl { get; set; }
        public string FotoBannerUrl { get; set; }
        public string Edicao { get; set; }
        public ChampionshipStatusEnum Status { get; set; }
        public ChampionshipType Tipo { get; set; }
        public Platform Plataforma { get; set; }

        public IList<Team> Times { get; set; }
        public IList<Match> Jogos { get; set; }
    }
}