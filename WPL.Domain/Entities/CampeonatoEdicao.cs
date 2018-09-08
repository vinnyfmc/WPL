﻿using System;
using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class CampeonatoEdicao : _EntityBase
    {
        public CampeonatoEdicao()
        {

        }

        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string ImagemLogo { get; set; }
        public string ImagemBanner { get; set; }
        public string ImagemPremiacao { get; set; }
        public string ImagemRegulamento { get; set; }
        public CampeonatoStatusEnum Status { get; set; }
        public CampeonatoTipoEnum Tipo { get; set; }

        public long CampeonatoId { get; set; }
        public virtual Campeonato Campeonato { get; set; }

        public virtual ICollection<CampeonatoEdicaoFase> Fases { get; set; }
        public virtual ICollection<CampeonatoEdicaoTime> Times { get; set; }

        public CampeonatoEdicao(
            long idJogador,
            DateTime dataInicio,
            DateTime? dataFim,
            string imagemLogo,
            string imagemPremiacao,
            string imagemRegulamento,
            CampeonatoTipoEnum tipo,
            Campeonato Campeonato
            )
            :base(idJogador)
        {
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.ImagemLogo = imagemLogo;
            this.ImagemPremiacao = imagemPremiacao;
            this.ImagemRegulamento = imagemRegulamento;
            this.Status = CampeonatoStatusEnum.AguardandoInicio;
            this.Tipo = tipo;
            this.Campeonato = Campeonato;
        }
    }
}
