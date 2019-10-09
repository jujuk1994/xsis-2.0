using ngxsis.ViewModel;
using ngxsis.Web.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngxsis.Web.Controllers
{
    public class ProfilController : Controller
    {
        // GET: Profil
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListProfile()
        {
            return PartialView("_ListProfile");
        }

        public ActionResult UnduhProfil(ProfilViewModel getProfil)
        {
            List<ProfilViewModel> dataProfil = new List<ProfilViewModel>();
            dataProfil.Add(getProfil);
            ProfilReport reportReport = new ProfilReport();
            byte[] abytes = reportReport.PrepareReport(dataProfil);
            return File(abytes, "Application/pdf");
        }
    }
}