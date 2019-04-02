using AutoMapper;
using DesafioService;
using DesafioWeb.ViewModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioWeb.Controllers
{
    
    public class ClienteController : Controller
    {
        ClienteService _serviceCliente = new ClienteService();
        PorteEmpresaService _servicePorte = new PorteEmpresaService();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
    
        public JsonResult GetClientes()
        {
            var clientes = from c in Mapper.Map<List<Cliente>, List<ClienteVM>>(_serviceCliente.GetAll().Where(p => p.DataExclusao == null).ToList())
                           join p in Mapper.Map<List<PorteEmpresa>, List<PorteEmpresaVM>>(_servicePorte.GetAll().Where(p => p.DataExclusao == null).ToList())
                           on c.IDPorteEmpresa equals p.IDPorteEmpresa
                           select new
                           {
                               c,
                               p
                           };
            List<ClienteVM> listCliente = new List<ClienteVM>();
            foreach(var cliente in clientes)
            {
                ClienteVM c = new ClienteVM();
                c.IDCliente = cliente.c.IDCliente;
                c.IDPorteEmpresa = cliente.c.IDPorteEmpresa;
                c.NomeCliente = cliente.c.NomeCliente;
                c.NomePorteEmpresa = cliente.p.NomePorteEmpresa;
                listCliente.Add(c);
                    
            }
                           
            return Json(listCliente, JsonRequestBehavior.AllowGet);
        }
        

        public ActionResult Create()
        {
            ViewBag.PorteEmpresaID = new SelectList(Mapper.Map<List<PorteEmpresa>, 
                List<PorteEmpresaVM>>(_servicePorte.GetAll().Where(p => p.DataExclusao == null).ToList()), "IDPorteEmpresa", "NomePorteEmpresa");
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                _serviceCliente.Add(Mapper.Map<ClienteVM, Cliente>(clienteVM));
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Editar(int id)
        {
            ClienteVM cli = Mapper.Map<Cliente, ClienteVM>(_serviceCliente.Get(id));
            ViewBag.PorteEmpresaID = new SelectList(Mapper.Map<List<PorteEmpresa>,
                List<PorteEmpresaVM>>(_servicePorte.GetAll().Where(p => p.DataExclusao == null).ToList()), "IDPorteEmpresa", "NomePorteEmpresa", cli.IDPorteEmpresa);

            return View(cli);
        }
        [HttpPost]
        public ActionResult Editar(ClienteVM clienteVM)
        {
            if (ModelState.IsValid)
            {
                _serviceCliente.Update(Mapper.Map<ClienteVM, Cliente>(clienteVM));
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Cliente cli = _serviceCliente.Get(id);
            cli.DataExclusao = DateTime.Now;
            _serviceCliente.Delete(cli);
   
            return RedirectToAction("Index");
        }
    }
}