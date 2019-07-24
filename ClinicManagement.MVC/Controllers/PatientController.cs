using CM.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicManagement.MVC.Controllers
{
    public class PatientController : Controller
    {     
        IPatientInformationServices _pis;
        public PatientController(IPatientInformationServices pis)
        {
            _pis = pis;        
        }

        // GET: Patient
        public ActionResult PatientList()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PatientAdd()
        {
            return View();
        }
    }
}