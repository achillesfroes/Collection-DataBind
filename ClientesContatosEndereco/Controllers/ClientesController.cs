using Dados;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientesContatosEndereco.Controllers
{
    public class ClientesController : Controller
    {
        private ClientesContexto contexto = new ClientesContexto();

        public ActionResult Index()
        {
            return View(contexto.Clientes.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(contexto.Clientes.FirstOrDefault(c => c.ClienteId == id));
        }

        public ActionResult ListarContatos(int clienteId)
        {
            List<Contato> contatos = contexto.Clientes.FirstOrDefault(c => c.ClienteId == clienteId).Contatos.ToList();

            return PartialView(contatos);
        }

        public ActionResult ListarEnderecos(int clienteId)
        {
            List<Endereco> enderecos = contexto.Clientes.FirstOrDefault(c => c.ClienteId == clienteId).Enderecos.ToList();

            return PartialView(enderecos);
        }

        public ActionResult NovoContato()
        {
            ViewBag.Indexador = Guid.NewGuid();

            return PartialView();
        }

        public ActionResult NovoEndereco()
        {
            ViewBag.Indexador = Guid.NewGuid();

            return PartialView();
        }
    }
}