using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Application.Models
{
    public class JogadorModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string TagName { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Senha { get; set; }

        public JogadorModel(){}

        public JogadorModel(long id, string nome, string tagName, DateTime dataNascimento, string cpf, string email, string cep, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.TagName = tagName;
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
            this.Email = email;
            this.CEP = cep;
            this.Senha = senha;
        }
    }
}
