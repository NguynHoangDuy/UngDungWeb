using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2_611133539.Models;

namespace BaiTap2_611133539.Controllers
{
    public class SinhVien_61133539Controller : Controller
    {
        // GET: SinhVien_61133539
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UseRequest()
        {
            ViewBag.mssv = Request["mssv"];
            ViewBag.hoten = Request["hoten"];
            ViewBag.diem = Request["diem"];
            return View();
        }

        public ActionResult IndexAction()
        {
            return View();
        }
        public ActionResult UseAction(string mssv, string hoten, string diem)
        {
            ViewBag.mssv = mssv;
            ViewBag.hoten = hoten;
            ViewBag.diem = diem;
            return View();
        }
        public ActionResult IndexForm()
        {
            return View();
        }
        public ActionResult UseFormCollection(FormCollection form)
        {
            ViewBag.mssv = form["mssv"];
            ViewBag.hoten = form["hoten"];
            ViewBag.diem = form["diem"];
            return View();
        }

        public ActionResult IndexModel()
        {
            return View();
        }
        public ActionResult UseModel(UseModel model)
        {
            ViewBag.mssv = model.mssv;
            ViewBag.hoten = model.hoten;
            ViewBag.diem = model.diem;
            return View();
        }
    }
}