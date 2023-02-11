using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()  // É o nome da view Index.cshtml
        {
            var cliente = new Cliente()
            {
                Nome = "ASP",
                Sobrenome = "NET",
                DataCadastro = DateTime.Now,
                Id = 1
            };
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

        public ActionResult PesquisaCliente(int? id, string nome)  // http://localhost:28645/Cliente/PesquisaCliente/1?nome=João
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() {Nome = "João", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 1},
                new Cliente() {Nome = "Maria", Sobrenome = "Pereira", DataCadastro = DateTime.Now, Id = 2},
                new Cliente() {Nome = "José", Sobrenome = "Santos", DataCadastro = DateTime.Now, Id = 3},
                new Cliente() {Nome = "Paula", Sobrenome = "Silva", DataCadastro = DateTime.Now, Id = 4}
            };

            var cliente = listaClientes.Where(c => c.Nome == nome).ToList();

            return View("ListaClientes", cliente);
        }
    }
}