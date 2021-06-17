using AjaxPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxPost.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PostJson(ParamModel pModel)
        {
             string param1 = pModel.param1;
             string param2 = pModel.param2;

            
            return Json(param1 + " " + param2, JsonRequestBehavior.AllowGet);
        }
    }
}