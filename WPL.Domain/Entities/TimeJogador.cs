namespace WPL.Domain.Entities
{
    public class TimeJogador : _EntityBase
    {
        public TimeJogador()
        {

        }

        public bool EhManager { get; set; }
        public bool EhSubManager { get; set; }
        
        public Posicao PosicaoDefault { get; set; }
        public Jogador Jogador { get; set; }
        public Time Time { get; set; }
        public StatusEnum Status { get; set; }

        public TimeJogador(
            long idJogador,
            bool ehManager,
            bool ehSubManager,
            Posicao posicao,
            Jogador jogador,
            Time time
            )
            :base(idJogador)
        {
            this.EhManager = ehManager;
            this.EhSubManager = EhSubManager;
            this.PosicaoDefault = posicao;
            this.Jogador = jogador;
            this.Time = time;
            this.Status = StatusEnum.Ativo;
        }

    }
}
