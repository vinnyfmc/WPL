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

        public long JogadorSenhaId { get; set; }
        public JogadorSenha JogadorSenha { get; set; }
        public long PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }
        public long PosicaoId { get; set; }
        public Posicao PosicaoPreferida { get; set; }

        public ICollection<JogadorStatusHistorico> HistoricosStatus { get; set; }
        public ICollection<JogoJogador> JogosJogador { get; set; }
        public ICollection<TimeJogador> TimesJogador { get; set; }

        public Jogador(
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
            this.Plataforma = plataforma;
            this.PosicaoPreferida = posicaoPreferida;

            this.JogadorSenha = new JogadorSenha(
                idJogador,
                senha
                );

            this.HistoricosStatus.Add(new JogadorStatusHistorico(
                idJogador,
                JogadorStatusEnum.Criado,
                this
                ));
        }

        public JogadorStatusEnum GetStatus()
        {
            return this.HistoricosStatus.OrderByDescending(x => x.Id).Select(p => p.Status).FirstOrDefault();
        }

        public void UpdateJogadorSenha(
            long idJogador,
            string senha)
        {
            this.JogadorSenha.UpdateSenha(
                idJogador,
                senha);
        }

        public void AddStatus(long idJogador, JogadorStatusEnum status)
        {
            this.HistoricosStatus.Add(
                new JogadorStatusHistorico(
                    idJogador,
                    status,
                    this
                    ));
        }
        
        
    }
}
