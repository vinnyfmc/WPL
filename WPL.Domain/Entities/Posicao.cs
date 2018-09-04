namespace WPL.Domain.Entities
{
    public class Posicao : _EntityBase
    {
        public Posicao()
        {

        }

        private string Nome { get; set; }
        private string NomeAbreviado { get; set; }
        private string Logo { get; set; }
        private StatusEnum Status { get; set; }

        public Posicao(
            long idJogador, 
            string nome, 
            string nomeAbreviado, 
            string logo, 
            StatusEnum status)
            : base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = NomeAbreviado;
            this.Logo = logo;
            this.Status = status;
        }

    }
}
