using jogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace jogo.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa os varios codigos HTTP
        //Codigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            //ViewBag = Reserva de espaço para armazenar informações para recuperar na VIEW.
            //Tem a função de carregar a VIEW
            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
