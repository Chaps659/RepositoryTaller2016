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
    public class ProfesorController : Controller
    {
        private readonly RepositoryProfesor _RepositoryProfesor = new RepositoryProfesor();

        public ActionResult Index()
        {
            var vistaAlumno = Mapper.Map<IEnumerable<Profesor>, IEnumerable<VistaProfesor>>(_RepositoryProfesor.GetAll());
            return View(vistaAlumno);
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VistaProfesor profesor)
        {

            if (ModelState.IsValid)
            {
                var profesorDominio = Mapper.Map<VistaProfesor, Profesor>(profesor);
                _RepositoryProfesor.Add(profesorDominio);

                return RedirectToAction("Index");
            }

            return View(profesor);
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profesor/Edit/5
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

        // GET: Profesor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profesor/Delete/5
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
