using AutoMapper;
using Proyecto.DDD.Data.Repositorio;
using Proyecto.DDD.Dominio.Entidades;
using Proyecto.DDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.DDD.MVC.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly RepositoryAlumno _RepositoryAlumno = new RepositoryAlumno();

        public ActionResult Index()
        {
            var vistaAlumno = Mapper.Map<IEnumerable<Alumno>, IEnumerable<VistaAlumno>>(_RepositoryAlumno.GetAll());
            return View(vistaAlumno);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VistaAlumno alumno)
        {

            if (ModelState.IsValid)
            {
                var alumnoDominio = Mapper.Map<VistaAlumno, Alumno>(alumno);
                _RepositoryAlumno.Add(alumnoDominio);

                return RedirectToAction("Index");
            }

            return View(alumno);
        }



        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
