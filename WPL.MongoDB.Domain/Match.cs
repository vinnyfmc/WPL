using static WPL.MongoDB.Domain.Enum;

namespace WPL.MongoDB.Domain
{
    public class Match
    {
        public long Id { get; set; }
        public Team TimeCasa { get; set; }
        public Team TimeVisitante { get; set; }
        public int TimeCasaGols { get; set; }
        public int TimeVisitanteGols { get; set; }
        public string FotoPlacarTimeCasaUrl { get; set; }
        public string FotoPlacarTimeVisitanteUrl { get; set; }
        public MatchStatusEnum Status { get; set; }
    }
}