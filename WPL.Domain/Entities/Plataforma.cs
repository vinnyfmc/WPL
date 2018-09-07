namespace WPL.Domain.Entities
{
    public class Plataforma : _EntityBase
    {
        public Plataforma()
        {

        }

        private string Nome { get; set; }
        private string NomeAbreviado { get; set; }
        private string Logo { get; set; }
        private StatusEnum Status { get; set; }

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
