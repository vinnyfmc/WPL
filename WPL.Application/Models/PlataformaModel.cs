namespace WPL.Application.Models
{
    public class PlataformaModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeAbreveado { get; set; }
        public string Logo { get; set; }

        public PlataformaModel(long id, string nome, string nomeAbreveado, string logo)
        {
            this.Id = id;
            this.Nome = nome;
            this.NomeAbreveado = nomeAbreveado;
            this.Logo = logo;
        }
    }
}
