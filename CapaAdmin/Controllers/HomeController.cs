using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;

namespace CapaAdmin.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Administradores()
        {
            return View();
        }
        public ActionResult Pedidos()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListarAdministradores() {
        
            List<Administrador> oLista = new List<Administrador>();

            oLista = new CN_Administradores().Listar();

            return Json(oLista,JsonRequestBehavior.AllowGet);
        }

    }
}