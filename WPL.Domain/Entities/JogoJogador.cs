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

        public int Gols { get; set; }
        public int Assistencias { get; set; }
        public decimal Nota { get; set; }
        public bool CartaoAmarelo { get; set; }
        public bool CartaoVermelho { get; set; }
        public bool MelhorEmCampo { get; set; }

        public Jogo Jogo{ get; set; }
        public Jogador Jogador { get; set; }
        public Posicao Posicao { get; set; }
    }
}
