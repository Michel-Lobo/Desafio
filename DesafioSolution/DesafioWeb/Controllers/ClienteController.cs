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
        ClienteService _service = new ClienteService();
        PorteEmpresaService _porte = new PorteEmpresaService();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Create()
        {
            var portes = Mapper.Map<List<PorteEmpresa>, List<PorteEmpresaVM>>(_porte.GetAll().ToList());
            ViewBag.PorteEmpresaId = new SelectList("IDPorteEmpresa", "NomePorteEmpresa", portes);
            return View("Create", portes);
        }

        //public ActionResult Update()
        //{

        //}


    }
}