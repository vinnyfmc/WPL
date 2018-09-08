namespace WPL.Domain.Entities
{
    public class CampeonatoEdicaoTime : _EntityBase
    {
        public CampeonatoEdicaoTime()
        {

        }

        public StatusEnum Status { get; set; }

        public long CampeonatoEdicaoId { get; set; }
        public virtual CampeonatoEdicao CampeonatoEdicao { get; set; }
        public long TimeId { get; set; }
        public virtual Time Time { get; set; }

        public CampeonatoEdicaoTime(
            long idJogador,
            CampeonatoEdicao campeonatoEdicao,
            Time time)
            :base(idJogador)
        {
            this.Status = StatusEnum.Inativo;
            this.CampeonatoEdicao = campeonatoEdicao;
            this.Time = time;
        }
    }
}
