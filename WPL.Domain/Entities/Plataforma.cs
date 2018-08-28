namespace WPL.Domain.Entities
{
    public class Plataforma : _EntityBase
    {
        public string Nome { get; set; }
        public string NomeAbrevado { get; set; }
        public string Logo { get; set; }
        public StatusEnum Status { get; set; }

        public Plataforma(){}

        public Plataforma(
            long idJogador, 
            string nome, 
            string nomeAbrevado, 
            string logo, 
            StatusEnum status)
            : base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbrevado = nomeAbrevado;
            this.Logo = logo;
            this.Status = status;
        }
    }
}
