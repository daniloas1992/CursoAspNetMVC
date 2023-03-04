using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;
using Aula1AspNetMVC.Context;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()  // É o nome da view Index.cshtml
        {
            /*var cliente = new Cliente()
            {
                Nome = "ASP",
                Sobrenome = "NET",
                DataCadastro = DateTime.Now,
                Id = 1
            };*/

            //var cliente = new Aula1Context().Cliente.Where(c => c.Id == 1).SingleOrDefault();

            var cliente = new Aula1Context().Cliente.SingleOrDefault(c => c.Id == 1);

            ViewBag.Cliente = cliente;

            //ViewData["Cliente"] = cliente;

            return View(cliente); // Se o ActionResult tiver nome diferente precia passar o nome da view como parâmetro
                                 // return View("Index", cliente)
        }

        public ActionResult ListaClientes()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "João", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Maria", Sobrenome = "Pereira", DataCadastro = DateTime.Now, Id = 2},
                new Cliente() {Nome = "José", Sobrenome = "Santos", DataCadastro = DateTime.Now, Id = 3},
                new Cliente() {Nome = "Paula", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 4}
            };

            return View(listaClientes);
        }

        public ActionResult PesquisaCliente(int? idCliente, string nomeCliente)  // http://localhost:28645/Cliente/PesquisaCliente/1?nomeCliente=João
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "João", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Maria", Sobrenome = "Pereira", DataCadastro = DateTime.Now, Id = 2},
                new Cliente() {Nome = "José", Sobrenome = "Santos", DataCadastro = DateTime.Now, Id = 3},
                new Cliente() {Nome = "Paula", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 4}
            };

            var cliente = listaClientes.Where(c => c.Nome == nomeCliente).ToList();

            // http://localhost:28645/Cliente/PesquisaCliente/idCliente=1&nomeCliente=João

            if (!cliente.Any())
            {
                TempData["error"] = "Nenhum cliente selecionado!";
                return RedirectToAction("ErroPesquisa");
            }

            return View("ListaClientes", cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}