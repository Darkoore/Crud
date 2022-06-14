using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud2.Models;

namespace Crud2.Controllers
{
    public class CompromisosController : Controller
    {
        // GET: Compromisos
        public ActionResult Index()
        {
            ExternosBD dbhandle = new ExternosBD();
            ModelState.Clear();
            return View(dbhandle.LeerParticipantes());
        }

        // 2. *************ADD NEW STUDENT ******************
        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Externos smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ExternosBD sdb = new ExternosBD();
                    if (sdb.AñadirPart(smodel))
                    {
                        ViewBag.Message = "Se añadio al participante correctamente";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // 3. ************* EDIT STUDENT DETAILS ******************
        // GET: Student/Edit/5
        public ActionResult Edit(string PART_RUT)
        {
            ExternosBD sdb = new ExternosBD();
            return View(sdb.LeerParticipantes().Find(smodel => smodel.PART_RUT == PART_RUT));
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(string PART_RUT, Externos smodel)
        {
            try
            {
                ExternosBD sdb = new ExternosBD();
                sdb.ActualizarPart(smodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // 4. ************* DELETE STUDENT DETAILS ******************
        // GET: Student/Delete/5
        public ActionResult Delete(int PART_RUT)
        {
            try
            {
                ExternosBD sdb = new ExternosBD();
                if (sdb.BorrarPart(PART_RUT))
                {
                    ViewBag.AlertMsg = " Se ha borrado al participante con exito";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult AddYTabla()
        {
            ViewModel model = new ViewModel();
            ieExternos = _dbcontext.ieExternos.ToList(),
            mExternos = new mExternos()
        };
        return View(model);





    }
}
