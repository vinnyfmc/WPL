namespace WPL.Domain.Entities
{
    public class Posicao : _EntityBase
    {
        public string Nome { get; set; }
        public string NomeAbrevado { get; set; }
        public string Logo { get; set; }
        public StatusEnum Status { get; set; }

        public Posicao(){}

        public Posicao(
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
