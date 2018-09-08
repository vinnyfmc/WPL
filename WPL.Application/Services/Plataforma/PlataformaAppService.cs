﻿using System.Collections.Generic;
using System.Linq;
using WPL.Application.Models;
using WPL.Application.Services;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Application
{
    public class PlataformaAppService : IPlataformaAppService
    {
        IPlataformaRepository plataformaRepository;
        public PlataformaAppService(IPlataformaRepository plataformaRepository)
        {
            this.plataformaRepository = plataformaRepository;
        }

        public IEnumerable<PlataformaModel> GetAll()
        {
            IEnumerable<Plataforma> plataformas = plataformaRepository.GetAll();
            List<PlataformaModel> plataformasModel = new List<PlataformaModel>();
            foreach(Plataforma p in plataformas)
            {
                plataformasModel.Add(
                    new PlataformaModel(p.Id, p.Nome, p.NomeAbreviado, p.ImagemLogo)
                );
            }
            
            return plataformasModel.AsEnumerable();
        }
    }
}
