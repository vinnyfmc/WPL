using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WPL.Application.Models;
using WPL.Application.Services;
using WPL.Web.Models;

namespace WPL.Web.Controllers
{
    public class HomeController : Controller
    {
        ICampeonatoEdicaoAppService campeonatoEdicaoAppService;
        public HomeController(
            ICampeonatoEdicaoAppService campeonatoEdicaoAppService
            )
        {
            this.campeonatoEdicaoAppService = campeonatoEdicaoAppService;
        }


        public IActionResult Index()
        {
            IEnumerable<CampeonatoEdicaoModel> edicoes;
            edicoes = campeonatoEdicaoAppService.GetUltimaEdicaoPorPlataformas();

            return View(edicoes);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
