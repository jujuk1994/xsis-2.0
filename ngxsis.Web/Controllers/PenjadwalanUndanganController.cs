using ngxsis.Repositories;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngxsis.Web.Controllers
{
    public class PenjadwalanUndanganController : Controller
    {
        // GET: PenjadwalanUndangan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string search)
        {
            PenjadwalanUndanganRepo penjadwalanUndanganRepo = new PenjadwalanUndanganRepo();
            List<PenjadwalanUndanganViewModel> SearchUndangan = penjadwalanUndanganRepo.Search(search);
            if (SearchUndangan.Count == 0 || SearchUndangan == null)
            {
                SearchUndangan.Add(new PenjadwalanUndanganViewModel { Fullname = "KOSONG" });
                return Json(SearchUndangan, JsonRequestBehavior.AllowGet);
            }
            else
            {

                return Json(SearchUndangan, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult List()
        {
            return PartialView("_List");
        }
    }
}