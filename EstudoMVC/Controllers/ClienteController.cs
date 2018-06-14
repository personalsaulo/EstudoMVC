using EstudoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudoMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalhe()
        {
            //logica de acesso aos dados usando entidades
            //ado.net, entity framework, Nhibernate

            Cliente cliente = new Cliente()
            {
                Id = 200,
                Nome = "Saulo",
                Telefone = "2345678",
                Email = "teste@teste.com"

            };

            return View(cliente);
        }
        [HttpPost]
        public ActionResult SalvarCliente(Cliente cliente)
        {
            return View(cliente);
        }
    }
}