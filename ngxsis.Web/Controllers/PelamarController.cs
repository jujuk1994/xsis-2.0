using ngxsis.Models;
using ngxsis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngxsis.Web.Controllers
{
    public class PelamarController : Controller
    {
        // GET: Pelamar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            PelamarRepo biodataRepo = new PelamarRepo();
            List<x_biodata> ListBiodata = biodataRepo.GetAll();
            return Json(ListBiodata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DetailPelamar()
        {
            return PartialView("_DetailPelamar");
        }

        public ActionResult Search(string search)
        {
            PelamarRepo biodataRepo = new PelamarRepo();
            List<x_biodata> SearchBiodata = biodataRepo.Search(search);
            if (SearchBiodata.Count == 0 || SearchBiodata == null)
            {
                SearchBiodata.Add(new x_biodata { fullname = "KOSONG" });
                return Json(SearchBiodata, JsonRequestBehavior.AllowGet);
            }
            else
            {

                return Json(SearchBiodata, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult OrderBy(string search)
        {
            PelamarRepo biodataRepo = new PelamarRepo();
            List<x_biodata> OrderBiodata = biodataRepo.OrderBy(search);
            return Json(OrderBiodata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OrderByDesc(string search)
        {
            PelamarRepo biodataRepo = new PelamarRepo();
            List<x_biodata> OrderBiodata = biodataRepo.OrderByDesc(search);
            return Json(OrderBiodata, JsonRequestBehavior.AllowGet);
        }
    }
}