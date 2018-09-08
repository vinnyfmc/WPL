using System;
using System.Collections.Generic;
using System.Text;
using WPL.Domain;

namespace WPL.Application.Models
{
    public class CampeonatoEdicaoModel
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string ImagemLogo { get; set; }
        public string ImagemBanner { get; set; }
        public string ImagemPremiacao { get; set; }
        public string ImagemRegulamento { get; set; }

        public string PlataformaImagemLogo { get; set; }
        public string PlataformaNomeAbreviado { get; set; }
        public bool PlataformaDefault { get; set; }

        public CampeonatoEdicaoModel(
            string nome,
            DateTime dataInicio,
            DateTime? dataFim,
            string imagemLogo,
            string imagemBanner,
            string imagemPremiacao,
            string imagemRegulamento,
            CampeonatoTipoEnum tipo,
            string plataformaImagemLogo,
            string plataformaNomeAbreviado,
            bool plataformaDefault)
        {
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.ImagemLogo = imagemLogo;
            this.ImagemBanner = imagemBanner;
            this.ImagemPremiacao = imagemPremiacao;
            this.ImagemRegulamento = imagemRegulamento;
            this.PlataformaImagemLogo = plataformaImagemLogo;
            this.PlataformaNomeAbreviado = plataformaNomeAbreviado;
            this.PlataformaDefault = plataformaDefault;
        }
    }
}
