using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class JogoTime : _EntityBase
    {
        public JogoTime()
        {

        }

        private int? GolsCasa { get; set; }
        private int? GolsFora { get; set; }
        private string ImagemPlacar { get; set; }
        private string ImagemAssistencias { get; set; }
        private string ImagemGols { get; set; }
        private string ImagemNotas { get; set; }

        private Jogo Jogo { get; set; }
        private Time Time { get; set; }
        private StatusEnum Confirmado { get; set; }

        public JogoTime(
            long idJogador,
            Jogo jogo,
            Time time)
            : base(idJogador)
        {
            this.Jogo = jogo;
            this.Time = time;
            this.Confirmado = StatusEnum.Inativo;
        }
    }
}
