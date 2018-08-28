using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class JogadorStatusHistorico : _EntityBase
    {
        public JogadorStatusEnum Status { get; set; }
        public Jogador Jogador { get; set; }

        public JogadorStatusHistorico(){}

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
