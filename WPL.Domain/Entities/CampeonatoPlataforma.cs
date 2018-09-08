using System;
using System.Collections.Generic;
using System.Text;

namespace WPL.Domain.Entities
{
    public class CampeonatoPlataforma : _EntityBase
    {
        public CampeonatoPlataforma()
        {

        }

        public StatusEnum Status { get; set; }

        public long CampeonatoId { get; set; }
        public Campeonato Campeonato { get; set; }
        public long PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        public CampeonatoPlataforma(
            long idJogador,
            Campeonato campeonato,
            Plataforma plataforma
            )
            :base(idJogador)
        {
            this.Status = StatusEnum.Ativo;
            this.Campeonato = campeonato;
            this.Plataforma = plataforma;
        }

    }
}
