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
        private JogoStatusEnum Status { get; set; }

        public Jogo(
            long idJogador,
            DateTime data,
            int golsCasa,
            int golsFora,
            CampeonatoEdicaoFase fase,
            JogoTime timeCasa,
            JogoTime timeFora,
            StatusEnum concluido)
            :base (idJogador)
        {
            this.Data = data;
            this.GolsCasa = golsCasa;
            this.GolsFora = golsFora;
            this.Fase = fase;
            this.TimeCasa = timeCasa;
            this.TimeFora = timeFora;
            this.Status = JogoStatusEnum.Criado;
        }
    }
}
