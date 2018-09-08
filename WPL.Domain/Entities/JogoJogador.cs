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
        public decimal? Nota { get; set; }
        public bool CartaoAmarelo { get; set; }
        public bool CartaoVermelho { get; set; }
        public bool MelhorEmCampo { get; set; }

        public long JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public long JogadorId { get; set; }
        public Jogador Jogador { get; set; }
        public long PosicaoId { get; set; }
        public Posicao Posicao { get; set; }


        public JogoJogador(
            long idJogador,
            int gols,
            int assistencias,
            decimal? nota,
            bool cartaoAmarelo,
            bool cartaoVermelho,
            bool melhorEmCampo,
            Jogo jogo,
            Jogador jogador,
            Posicao posicao)
            : base(idJogador)
        {
            this.Gols = gols;
            this.Assistencias = assistencias;
            this.Nota = nota;
            this.CartaoAmarelo = cartaoAmarelo;
            this.CartaoVermelho = cartaoVermelho;
            this.MelhorEmCampo = melhorEmCampo;
            this.Jogo = jogo;
            this.Jogador = jogador;
            this.Posicao = posicao;
        }
    }
}
