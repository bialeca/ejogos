using jogo.Models;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Cadastrar (IFormCollection form)
        {
            //criar novo objeto a partir do front end
            Equipe novaEquipe = new Equipe();

            novaEquipe.idEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            //chama função criar passando um objeto do tipo equipe
            equipeModel.Criar(novaEquipe);

            ViewBag.Equipes = equipeModel.LerEquipes(); 
            return LocalRedirect("~/Equipe");
        }


    }
}
