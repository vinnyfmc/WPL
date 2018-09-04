using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class JogoJogador : _EntityBase
    {
        public JogoJogador()
        {

        }

        private int Gols { get; set; }
        private int Assistencias { get; set; }
        private decimal Nota { get; set; }
        private bool CartaoAmarelo { get; set; }
        private bool CartaoVermelho { get; set; }
        private bool MelhorEmCampo { get; set; }

        private Jogo Jogo{ get; set; }
        private Jogador Jogador { get; set; }
        private Posicao Posicao { get; set; }


    }
}
