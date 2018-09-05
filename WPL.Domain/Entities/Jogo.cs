using System;

namespace WPL.Domain.Entities
{
    public class Jogo : _EntityBase
    {
        public Jogo()
        {

        }

        public DateTime Data { get; set; }
        public int GolsCasa { get; set; }
        public int GolsFora { get; set; }
        public StatusEnum Concluido { get; set; }

        public CampeonatoEdicaoFase Fase { get; set; }
        public JogoTime TimeCasa { get; set; }
        public JogoTime TimeFora { get; set; }
    }
}
