using System;
using System.Collections.Generic;

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
        public JogoStatusEnum Status { get; set; }

        public long CampeonatoEdicaoFaseId { get; set; }
        public virtual CampeonatoEdicaoFase CampeonatoEdicaoFase { get; set; }
        public long TimeCasaId { get; set; }
        public virtual JogoTime TimeCasa { get; set; }
        public long TimeForaId { get; set; }
        public virtual JogoTime TimeFora { get; set; }

        public virtual ICollection<JogoJogador> JogoJogadores { get; set; }
        public virtual ICollection<JogoTime> JogoTimes { get; set; }

        public Jogo(
            long idJogador,
            DateTime data,
            int golsCasa,
            int golsFora,
            CampeonatoEdicaoFase campeonatoEdicaoFase,
            JogoTime timeCasa,
            JogoTime timeFora,
            StatusEnum concluido)
            :base (idJogador)
        {
            this.Data = data;
            this.GolsCasa = golsCasa;
            this.GolsFora = golsFora;
            this.CampeonatoEdicaoFase = campeonatoEdicaoFase;
            this.TimeCasa = timeCasa;
            this.TimeFora = timeFora;
            this.Status = JogoStatusEnum.Criado;
        }
    }
}
