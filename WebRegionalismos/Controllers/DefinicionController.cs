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
    public class DefinicionController : Controller
    {
        private RepositorioPalabraDefinicion repositorio = new RepositorioPalabraDefinicion();

        private RepositorioPais repoPais = new RepositorioPais();
        private RepositorioIdioma repoIdioma = new RepositorioIdioma();

        public ActionResult Index()
        {
            return View(repositorio.listarDefinicionPalabra());
        }



        public ActionResult Crear()
        {
            List<Pais> listaPaises = new List<Pais>();
            listaPaises = repoPais.ListarPaises();
            ViewBag.ListaPaises = listaPaises;

            List<Idioma> listaIdioma = new List<Idioma>();
            listaIdioma = repoIdioma.ListarIdiomas();
            ViewBag.ListaIdioma = listaIdioma;

            return View();
        }

        [HttpPost]
        public JsonResult Crear(string idPais, string idIdioma, string palabra, string definicion)
        {
            try
            {
                Palabra _palabra = new Palabra {
                    DescripcionPalabra = palabra
                };

                Definicion _definicion = new Definicion {
                     Palabra = _palabra,
                     IdPais = idPais, 
                     IdIdioma = Convert.ToInt32(idIdioma),
                     Definicion1 = definicion

                };

                if (!ModelState.IsValid)
                    return Json(false);
                repositorio.AgregarPalabraDefinicion(_definicion);
                return Json(true);
            }
            catch
            {
                return Json(false);
            }

          

            //// GET: Definicion/Create
            //public ActionResult Create()
            //{
            //    return View();
            //}

            //// POST: Definicion/Create
            //[HttpPost]
            //public ActionResult Create(FormCollection collection)
            //{
            //    try
            //    {
            //        // TODO: Add insert logic here

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}

            //// GET: Definicion/Edit/5
            //public ActionResult Edit(int id)
            //{
            //    return View();
            //}

            //// POST: Definicion/Edit/5
            //[HttpPost]
            //public ActionResult Edit(int id, FormCollection collection)
            //{
            //    try
            //    {
            //        // TODO: Add update logic here

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}

            //// GET: Definicion/Delete/5
            //public ActionResult Delete(int id)
            //{
            //    return View();
            //}

            //// POST: Definicion/Delete/5
            //[HttpPost]
            //public ActionResult Delete(int id, FormCollection collection)
            //{
            //    try
            //    {
            //        // TODO: Add delete logic here

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}
        }
}
