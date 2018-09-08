namespace WPL.Domain.Entities
{
    public class JogadorStatusHistorico : _EntityBase
    {
        public JogadorStatusHistorico()
        {

        }

        public JogadorStatusEnum Status { get; set; }

        public long JogadorId { get; set; }
        public virtual Jogador Jogador { get; set; }

        public JogadorStatusHistorico(
            long idJogador, 
            JogadorStatusEnum status, 
            Jogador jogador)
            : base(idJogador)
        {
            this.Status = status;
            this.Jogador = jogador;
        }
    }
}
