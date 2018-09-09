using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPL.Application.Models;
using WPL.Application.Transformation;
using WPL.Domain;
using WPL.Domain.Entities;
using WPL.Domain.Interfaces.Repositories;

namespace WPL.Application.Services
{
    public class CampeonatoEdicaoAppService : ICampeonatoEdicaoAppService
    {
        ICampeonatoEdicaoRepository campeonatoEdicaoRepository;
        IPlataformaRepository plataformaRepository;
        public CampeonatoEdicaoAppService(
            ICampeonatoEdicaoRepository campeonatoEdicaoRepository,
            IPlataformaRepository plataformaRepository)
        {
            this.campeonatoEdicaoRepository = campeonatoEdicaoRepository;
            this.plataformaRepository = plataformaRepository;
        }

        public IEnumerable<CampeonatoEdicaoModel> GetUltimaEdicaoPorPlataformas()
        {
            






            List<CampeonatoEdicaoModel> campeonatoEdicaoModel = new List<CampeonatoEdicaoModel>();
            IEnumerable<Plataforma> plataformas;
            plataformas = plataformaRepository.GetAll().Where(x => x.Status == StatusEnum.Ativo);
            foreach (Plataforma plataforma in plataformas)
            {
                CampeonatoEdicao edicao = campeonatoEdicaoRepository.GetUltimoCampeonatoPorPlataforma(plataforma.Id);

                if(edicao != null)
                    campeonatoEdicaoModel.Add(
                        CampeonatoEdicaoTransformation.CampeonatoEdicaoEmCampeonatoEdicaoModel(edicao)
                    );
            }
           
            return campeonatoEdicaoModel.AsEnumerable();

        }
    }
}
