namespace WPL.Domain.Entities
{
    public class CampeonatoEdicaoTime : _EntityBase
    {
        public CampeonatoEdicaoTime()
        {

        }

        public StatusEnum Status { get; set; }

        public CampeonatoEdicao Edicao { get; set; }
        public Time Time { get; set; }
    }
}
