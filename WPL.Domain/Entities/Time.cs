﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace WPL.Domain.Entities
{
    public class Time : _EntityBase
    {
        public Time()
        {

        }

        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public DateTime DataFundacao { get; set; }
        public string ImagemLogo { get; set; }
        public TimeStatusEnum Status { get; set; }

        public long PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        public IEnumerable<CampeonatoEdicaoTime> CampeonatoEdicoes { get; set; }
        public IEnumerable<JogoTime> JogosTime { get; set; }
        public IEnumerable<TimeJogador> TimeJogadores { get; set; }

        public Time(
            long idJogador,
            string nome,
            string nomeAbreviado,
            DateTime dataFundacao,
            string imagemLogo,
            Plataforma plataforma)
            :base(idJogador)
        {
            this.Nome = nome;
            this.NomeAbreviado = nomeAbreviado;
            this.DataFundacao = dataFundacao;
            this.ImagemLogo = imagemLogo;
            this.Plataforma = plataforma;
            this.Status = TimeStatusEnum.Ativo;
        }
    }
}
