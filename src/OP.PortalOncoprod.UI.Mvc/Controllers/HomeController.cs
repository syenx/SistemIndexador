using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using OP.PortalOncoprod.UI.Mvc.Models;

namespace SistemaIndexador.UI.Mvc.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void upload(string data)
        {

            string directory = @"C:\Temp\UploadIndexador\old\";

            for (int i = 0; i < Request.Files.Keys.Count; i++)
            {

                HttpPostedFileBase file = Request.Files[i];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);

                    file.SaveAs(Path.Combine(directory, fileName));
                }
            }





            ViewBag.Message = "Your contact page.";
        }
    }
}