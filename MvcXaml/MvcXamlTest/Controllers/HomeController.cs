// Copyright (c) 2011 Chris Pietschmann <http://pietschsoft.com>
//
// This file is part of MvcXaml <http://mvcxaml.codeplex.com>
//
// For licensing info goto <http://mvcxaml.codeplex.com/license>

using System.Web.Mvc;
using MvcXaml;
using System.Collections;
using System.Collections.Generic;

namespace MvcXamlTest.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Test1ImageA()
        {
            ViewData["Message"] = "Hello from the Controller in Test1ImageA";

            return View("Test1");
        }

        public ActionResult Test1ImageB()
        {
            var model = new {
                Message = "Hello from the Controller in Test1ImageB"
            };

            return View("Test1", model);
        }

        public ActionResult Person(int? id)
        {
            var model = GetPersonByID(id);

            return View(model);
        }

        public ActionResult MirroredText(string text)
        {
            var model = new
            {
                Text = text
            };
            return View(model);
        }

        public ActionResult BarGraph()
        {
            var model = new
            {
                height = 100,
                data = new List<object>() {
                    new { title = "One", value = 25 },
                    new { title = "Two", value = 50 },
                    new { title = "Three", value = 75 }
                }
            };
            return View(model);
        }

        private object GetPersonByID(int? id)
        {
            string firstname = string.Empty;
            string lastname = string.Empty;
            if (id == 0)
            {
                firstname = "Thomas";
                lastname = "Anderson";
            }
            else if (id == 1)
            {
                firstname = "John";
                lastname = "Mnemonic";
            }

            return new {
                ID = id,
                FirstName = firstname,
                LastName = lastname
            };
        }
    }
}
