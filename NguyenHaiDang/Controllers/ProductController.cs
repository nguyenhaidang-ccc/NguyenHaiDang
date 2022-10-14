using NguyenHaiDang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenHaiDang.Models;

namespace NguyenHaiDang.Controllers
{
    public class ProductController : Controller
    {
        WebBanVaLiEntities db = new WebBanVaLiEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult QuocGiaPartial()
        {
            List<tQuocGia> lstQG = db.tQuocGias.ToList();
            return PartialView(lstQG);
        }
    }
}