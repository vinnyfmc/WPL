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

        public int? GolsCasa { get; set; }
        public int? GolsFora { get; set; }
        public string ImagemPlacar { get; set; }
        public string ImagemAssistencias { get; set; }
        public string ImagemGols { get; set; }
        public string ImagemNotas { get; set; }
        public StatusEnum Confirmado { get; set; }

        public long JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public long TimeId { get; set; }
        public Time Time { get; set; }

        public IEnumerable<Jogo> JogosTimeCasa { get; set; }
        public IEnumerable<Jogo> JogosTimeFora { get; set; }

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
