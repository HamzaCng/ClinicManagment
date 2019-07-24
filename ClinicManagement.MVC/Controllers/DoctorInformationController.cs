using CM.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicManagement.MVC.Controllers
{
    public class DoctorInformationController : Controller
    {
        IDoctorInformationServices _dis;
        public DoctorInformationController(IDoctorInformationServices dis)
        {
            _dis = dis;
        }

        // GET: DoctorInformation
        public ActionResult ListDoctor()
        {
            return View(/*_dis.GetDoctorInformation().Data*/);             
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDoctor()
        {
            //var services = _dis.Add(); 
            return View();
        }
    }
}