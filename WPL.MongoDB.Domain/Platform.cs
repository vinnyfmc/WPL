namespace WPL.MongoDB.Domain
{
    public class Platform
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string FotoUrl { get; set; }
        public bool Ativo { get; set; }
    }
}