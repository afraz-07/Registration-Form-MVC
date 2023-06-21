using Registration_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Registration_Form.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit(Model mod)
        {
            Type myClassType = typeof(Model);
            PropertyInfo[] properties = myClassType.GetProperties();

            foreach (var item in properties)
            {
                if(item != null)
                {
                    return View();
                }

            }

            

            return View("Index");
        }
    }
}