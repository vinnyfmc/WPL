using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPL.Domain.Entities
{
    public class Jogador : _EntityBase
    {
        public Jogador()
        {

        }

        public string Nome { get; set; }
        public string TagName { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Senha { get; set; }
        public JogadorStatusEnum Status { get; set; }

        public Plataforma Plataforma { get; set; }
        public Posicao PosicaoPreferida { get; set; }

        public IEnumerable<JogadorStatusHistorico> HistoricosStatus { get; set; }

        public Jogador(
            long id,
            long idJogador,
            string nome,
            string tagName,
            DateTime dataNascimento,
            string cpf,
            string email,
            string cep,
            string senha,
            Plataforma plataforma,
            Posicao posicaoPreferida
            )
             : base(idJogador)
        {
            this.Nome = nome;
            this.TagName = tagName;
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
            this.Email = email;
            this.CEP = cep;
            this.Senha = senha;
            this.Plataforma = plataforma;
            this.PosicaoPreferida = posicaoPreferida;
        }

        public JogadorStatusEnum ObterStatus()
        {
            return this.HistoricosStatus.OrderByDescending(x => x.Id).Select(p => p.Status).FirstOrDefault();
        }
        
        public void IncluirStatus(long idJogador, JogadorStatusEnum status)
        {
            this.HistoricosStatus.ToList().Add(
                new JogadorStatusHistorico
                {
                    IdJogadorCadastro = idJogador,
                    DataCadastro = DateTime.Now,
                    IdJogadorAlteracao = idJogador,
                    DataAlteracao = DateTime.Now,
                    Jogador = this,
                    Status = status
                });
        }
        
        
    }
}
