using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class FirstController : Controller
    {
		public ActionResult Detail()
        {
			return Content("Hello from Controller!"); 
        }
    }
}
