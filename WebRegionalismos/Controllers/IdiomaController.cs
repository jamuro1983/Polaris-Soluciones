using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebRegionalismos.Models;

namespace WebRegionalismos.Controllers
{
    public class IdiomaController : Controller
    {
        private RepositorioIdioma repositorio = new RepositorioIdioma();
        
        public ActionResult Index()
        {
            return View(repositorio.ListarIdiomas());
        }


        public ActionResult Detalle(Int64 id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idioma idioma = repositorio.BuscarIdioma(id);
            if (idioma == null)
            {
                return HttpNotFound();
            }
            return View(idioma);
        }

        #region Crear Idioma

       
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "IdIdioma,DescripcionIdioma")] Idioma idioma)
        {
            if (ModelState.IsValid)
            {
                repositorio.AgregarIdioma(idioma);
                return RedirectToAction("Index");
            }

            return View(idioma);
        }
        #endregion

        #region Editar Idioma

        public ActionResult Editar(Int64 id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idioma idioma = repositorio.BuscarIdioma(id);
            if (idioma == null)
            {
                return HttpNotFound();
            }
            return View(idioma);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "IdIdioma,DescripcionIdioma")] Idioma idioma)
        {
            if (ModelState.IsValid)
            {
                repositorio.EditarIdioma(idioma);

                return RedirectToAction("Index");
            }
            return View(idioma);
        }
        #endregion

        public ActionResult Eliminar(Int64 id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idioma idioma = repositorio.BuscarIdioma(id);
            if (idioma == null)
            {
                return HttpNotFound();
            }
            return View(idioma);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarConfirmar(Int64 id)
        {
            Idioma idioma = repositorio.BuscarIdioma(id);

            repositorio.EliminarIdioma(idioma);

            return RedirectToAction("Index");
        }

        public ActionResult MostrarTodosIdiomas()
        {
            var idiomas = repositorio.ListarIdiomas();
            return PartialView("_MostrarTodosIdiomas", idiomas);
        }
    }
}