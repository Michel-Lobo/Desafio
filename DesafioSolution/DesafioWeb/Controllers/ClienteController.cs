using DesafioWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        public IEnumerable<PorteEmpresaVM> GetAllPorteEmpresa()
        {
            return null;
        }
    }
}