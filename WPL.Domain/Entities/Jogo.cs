using System;

namespace WPL.Domain.Entities
{
    public class Jogo : _EntityBase
    {
        public Jogo()
        {

        }

        private DateTime Data { get; set; }
        private int GolsCasa { get; set; }
        private int GolsFora { get; set; }

        private CampeonatoEdicaoFase Fase { get; set; }
        private JogoTime TimeCasa { get; set; }
        private JogoTime TimeFora { get; set; }
        private StatusEnum Concluido { get; set; }
    }
}
