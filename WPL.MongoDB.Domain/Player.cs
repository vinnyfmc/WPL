using System;
using System.Collections.Generic;
using static WPL.MongoDB.Domain.Enum;

namespace WPL.MongoDB.Domain
{
    public class Player
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string FotoUrl { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Manager { get; set; }
        public string Senha { get; set; }
        public Position Posicao { get; set; }
        public Platform Plataforma { get; set; }
        public StatusEnum Status { get; set; }

        public IList<CompleteInfo> Infos { get; set; }
        public IList<Team> Times { get; set; }
    }
}
