﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PageController : Controller
    {
        

        // GET: /Page/
        public ActionResult Show(string tytul)
        {
            if (String.IsNullOrEmpty(tytul))
                return RedirectToAction("Index", "Home");
            return View();
        }

    }
}
