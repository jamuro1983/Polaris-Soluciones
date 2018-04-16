using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using WebRegionalismos.Models;

namespace WebRegionalismos.Controllers
{
    public class PaisController : Controller
    {
        private RepositorioPais repositorio = new RepositorioPais();


        public ActionResult Index()
        {
            return View(repositorio.ListarPaises());
        }


        public ActionResult Detalle(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = repositorio.BuscarPais(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }


        #region Crear       
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "IdPais,DescripcionPais")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                repositorio.AgregarPais(pais);
                return RedirectToAction("Index");
            }

            return View(pais);
        }
        #endregion

        #region Editar
        public ActionResult Editar(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = repositorio.BuscarPais(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "IdPais,DescripcionPais")] Pais pais)
        {
            if (ModelState.IsValid)
            {
                repositorio.EditarPais(pais);

                return RedirectToAction("Index");
            }
            return View(pais);
        }


        #endregion

        #region Eliminar

        public ActionResult Eliminar(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pais pais = repositorio.BuscarPais(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarConfirmar(string id)
        {
            Pais pais = repositorio.BuscarPais(id);

            repositorio.EliminarPais(pais);

            return RedirectToAction("Index");
        }
        #endregion
        
 
        public ActionResult MostrarListaPaises()
        {
            List<Pais> listaPaises = new List<Pais>();
            listaPaises = repositorio.ListarPaises();
            return View(listaPaises);
        }
    }
}

