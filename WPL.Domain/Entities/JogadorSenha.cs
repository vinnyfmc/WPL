using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class JogadorSenha : _EntityBase
    {
        public JogadorSenha()
        {

        }

        public string Senha { get; set; }

        public Jogador Jogador { get; set; }

        public JogadorSenha(
            long idJogador,
            string senha,
            Jogador Jogador
            )
            :base(idJogador)
        {
            this.Senha = senha;
            this.Jogador = Jogador;
        }

        public void UpdateSenha(
            long idJogador,
            string senha
            )
        {
            this.Senha = senha;
            this.DataAlteracao = DateTime.Now;
            this.IdJogadorAlteracao = idJogador;
        }

    }
}
