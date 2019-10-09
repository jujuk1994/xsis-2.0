using ngxsis.Models;
using ngxsis.Repositories;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngxsis.Web.Controllers
{
    public class CatatanController : Controller
    {
        // GET: Catatan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
            CatatanRepo catatanRepo = new CatatanRepo();
            List<CatatanViewModel> catatanModel = catatanRepo.GetAll();

            return Json(catatanModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListCatatan()
        {
            return PartialView("_ListCatatan");
        }
        public ActionResult TambahCatatan()
        {
            return PartialView("_TambahCatatan");
        }
        public ActionResult SaveCatatan(x_catatan tambahCatatan)
        {
            CatatanRepo addCatatan = new CatatanRepo();

            if (addCatatan.SaveCatatan(tambahCatatan))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);

            }

        }
        public ActionResult EditCatatan()
        {
            return PartialView("_EditCatatan");
        }
        public ActionResult SaveEditCatatan(x_catatan editCatatan)
        {
            CatatanRepo saveEditCatatan = new CatatanRepo();


            if (saveEditCatatan.SaveEditCatatan(editCatatan))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);

            }
            return View();
        }
        public ActionResult Delete()
        {
            return PartialView("_Delete");
        }
        public ActionResult DeleteCatatan(x_catatan deleteCatatan)
        {
            CatatanRepo deleteEditCatatan = new CatatanRepo();


            if (deleteEditCatatan.DeleteEditCatatan(deleteCatatan))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);

            }
            return View();
        }
    }
}