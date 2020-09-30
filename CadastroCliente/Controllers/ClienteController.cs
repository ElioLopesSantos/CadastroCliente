using CadastroCliente.Models.Model;
using CadastroCliente.Models.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        ClienteNegocio _clienteNegocio =  new ClienteNegocio();
        // GET: Cliente
        public ActionResult Index()
        {
            var resultado = _clienteNegocio.GetAllClientes();
            return View(resultado);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteModel model)
        {
            try
            {
                _clienteNegocio.SalvarCliente(model);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                throw;
            }
               
           
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
           var resultado =  _clienteNegocio.GetClienteModelById(id);
            return View(resultado);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteModel model, int id )
        {
            try
            {
                var resultado = _clienteNegocio.GetClienteModelById(id);
                _clienteNegocio.AlterarCliente(model);

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var resultado = _clienteNegocio.GetClienteModelById(id);
            return View(resultado);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClienteModel clienteModel)
        {
            try
            {
                var resultado = _clienteNegocio.GetClienteModelById(id);
                _clienteNegocio.DeletarCliente(resultado);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
