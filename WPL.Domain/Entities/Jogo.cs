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
        
        public CampeonatoEdicaoFase Fase { get; set; }
        public JogoTime TimeCasa { get; set; }
        public JogoTime TimeFora { get; set; }
        public JogoStatusEnum Status { get; set; }

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
