using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMergeExercise.Models;

namespace WebAppMergeExercise.Controllers
{
    public class EmpController : Controller
    {
        static List<Emp> Emplist = new List<Emp>{
                new Emp() { EId = 1, EName = "John", EDesign="HR", EDOB="12/10/2019"},
                new Emp() { EId = 2, EName = "Aman", EDesign="Accountant", EDOB="17/05/2019"}
    };

        public ActionResult Index()
        {
            return View(Emplist);
        }
    }
}