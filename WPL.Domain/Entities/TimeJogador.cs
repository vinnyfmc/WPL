namespace WPL.Domain.Entities
{
    public class TimeJogador : _EntityBase
    {
        public TimeJogador()
        {

        }

        private bool EhManager { get; set; }
        private bool EhSubManager { get; set; }

        private Posicao Posicao { get; set; }
        private Jogador Jogador { get; set; }
        private Time Time { get; set; }
        private StatusEnum Status { get; set; }
    }
}
