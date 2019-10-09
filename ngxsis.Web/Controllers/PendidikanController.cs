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
    public class PendidikanController : Controller
    {
        // GET: Pendidikan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPendidikan()
        {

            return PartialView("_ListPendidikan");
        }

        public ActionResult AddPendidikan()
        {
            return PartialView("_AddPendidikan");
        }

        public ActionResult EditPendidikan()
        {
            return PartialView("_EditPendidikan");
        }

        public ActionResult DeletePendidikan()
        {

            return PartialView("_DeletePendidikan");
        }

        public ActionResult SavePendidikan(x_riwayat_pendidikan x_riwayat_pendidikan)
        {
            x_riwayat_pendidikan.is_delete = false;
            x_riwayat_pendidikan.create_by = 1;
            x_riwayat_pendidikan.create_on = DateTime.Now;
            x_riwayat_pendidikanRepo riwayat_pendidikanRepo = new x_riwayat_pendidikanRepo();
            if (riwayat_pendidikanRepo.Save(x_riwayat_pendidikan))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        public ActionResult SaveEditPendidikan(x_riwayat_pendidikan x_riwayat_pendidikan)
        {
            x_riwayat_pendidikan.is_delete = false;
            x_riwayat_pendidikan.create_by = 1;
            x_riwayat_pendidikan.create_on = DateTime.Now;
            x_riwayat_pendidikanRepo PendidikanRepo = new x_riwayat_pendidikanRepo();

            if (PendidikanRepo.SaveEdit(x_riwayat_pendidikan))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        public ActionResult SaveDeletePendidikan(isDeletedOrNOt x_riwayat_pendidikan)
        {
            //x_riwayat_pendidikan.delete_by = 1;
            //x_riwayat_pendidikan.delete_on = DateTime.Now;
            //x_riwayat_pendidikan.is_delete = true;
            x_riwayat_pendidikan.is_delete = true;
            //x_riwayat_pendidikan.create_by = 1;
            //x_riwayat_pendidikan.create_on = DateTime.Now;
            x_riwayat_pendidikanRepo PendidikanRepo = new x_riwayat_pendidikanRepo();
            //x_riwayat_pendidikan.is_delete = true;

            if (PendidikanRepo.delete2(x_riwayat_pendidikan))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        public ActionResult GetAll()
        {
            x_riwayat_pendidikanRepo PendidikanRepo = new x_riwayat_pendidikanRepo();
            List<PendidikanViewModel> x_riwayat_pendidikanModel = PendidikanRepo.GetAll();
            return Json(x_riwayat_pendidikanModel, JsonRequestBehavior.AllowGet);

        }
    }
}