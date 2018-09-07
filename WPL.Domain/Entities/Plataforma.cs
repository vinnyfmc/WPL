namespace WPL.Domain.Entities
{
    public class Plataforma : _EntityBase
    {
        public Plataforma()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public string Logo { get; set; }
        public StatusEnum Status { get; set; }

        public Plataforma(
            long idJogador, 
            string nome, 
            string nomeAbrevado, 
            string logo)
            : base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = nomeAbrevado;
            this.Logo = logo;
            this.Status = StatusEnum.Ativo;
        }
    }
}
