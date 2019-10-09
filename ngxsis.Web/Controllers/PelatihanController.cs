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
    public class PelatihanController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllPelatihan()
        {
            PelatihanRepo kr = new PelatihanRepo();
            return Json(kr.GetAllPelatihan(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult SavePelatihan(x_riwayat_pelatihan Pelatihan)
        {


            if (PelatihanRepo.SaveAddPelatihan(Pelatihan))
            {
                return Json(new { status = "berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "gagal" }, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult SaveEditPelatihan(x_riwayat_pelatihan Pelatihan)
        {

            Pelatihan.created_by = 1;
            Pelatihan.created_on = DateTime.Now;
            Pelatihan.modified_by = 1;
            Pelatihan.modified_on = DateTime.Now;
            Pelatihan.deleted_by = 1;
            Pelatihan.deleted_on = DateTime.Now;

            Pelatihan.is_delete = false;
            if (PelatihanRepo.SaveEdit(Pelatihan))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SaveDeletePelatihan(x_riwayat_pelatihan Pelatihan)
        {

            Pelatihan.created_by = 1;
            Pelatihan.created_on = DateTime.Now;
            Pelatihan.modified_by = 1;
            Pelatihan.modified_on = DateTime.Now;
            Pelatihan.deleted_by = 1;
            Pelatihan.deleted_on = DateTime.Now;

            Pelatihan.is_delete = true;
            if (PelatihanRepo.Delete(Pelatihan))
            {
                return Json(new { status = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { status = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult List()
        {
            return PartialView("_List");
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Edit()
        {
            return PartialView("_Edit");
        }

        public ActionResult Delete()
        {
            return PartialView("_Delete");
        }
    }
}