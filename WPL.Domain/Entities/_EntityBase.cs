using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class _EntityBase
    {
        public long Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public long IdJogadorCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public long IdJogadorAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public long? IdJogadorExclusao { get; set; }

        public _EntityBase()
        {

        }

        public _EntityBase(long idJogador)
        {
            this.IdJogadorCadastro = idJogador;
            this.IdJogadorAlteracao = idJogador;
            this.DataCadastro = DateTime.Now;
            this.DataAlteracao = DateTime.Now;
        }
    }
}
