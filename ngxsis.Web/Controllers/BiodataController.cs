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
    public class BiodataController : Controller
    {
        // GET: Biodata
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
            BiodataRepo biodataRepo = new BiodataRepo();
            List<BiodataViewModel> biodataModel = biodataRepo.GetAll();

            return Json(biodataModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListBiodata()
        {
            return PartialView("_ListBiodata");
        }
        public ActionResult EditBiodata()
        {
            return PartialView("_EditBiodata");
        }
        public ActionResult SaveEditBiodata(EditBiodataSplitter editBiodata)
        {
            BiodataRepo EditBiodata = new BiodataRepo();

            if (EditBiodata.SaveEditBiodata(editBiodata))
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