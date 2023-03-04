using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesafioJogos.Models;

namespace DesafioJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaJogos()
        {
            var listaJogos = new List<Jogo>()
            {
                new Jogo() {Nome = "God of War", Id=1},
                new Jogo() {Nome = "Hogwarts Legacy", Id=2},
                new Jogo() {Nome = "Call of Duty", Id=3},
                new Jogo() {Nome = "The Last of Us", Id=4},
                new Jogo() {Nome = "Horizen Forbidden", Id=5}
            };

            if (!listaJogos.Any())
            {
                TempData["error"] = "Nenhum jogo para exibir!";
                return RedirectToAction("ErroListaJogos");
            }

            return View(listaJogos);
        }

        public ActionResult ErroPesquisa()
        {
            return View("ErroListaJogos");
        }
    }
}