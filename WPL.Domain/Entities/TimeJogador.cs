namespace WPL.Domain.Entities
{
    public class TimeJogador : _EntityBase
    {
        public TimeJogador()
        {

        }

        public bool EhManager { get; set; }
        public bool EhSubManager { get; set; }
        public StatusEnum Status { get; set; }

        public Posicao PosicaoDefault { get; set; }
        public Jogador Jogador { get; set; }
        public Time Time { get; set; }   
    }
}
