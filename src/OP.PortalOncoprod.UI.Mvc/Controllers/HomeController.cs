using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using OP.PortalOncoprod.UI.Mvc.Models;
using SistemaIndexador.Application;
using SistemaIndexador.Application.Interfaces;
using SistemaIndexador.Application.ViewModels;

namespace SistemaIndexador.UI.Mvc.Controllers
{
    public class HomeController : BaseController
    {
        ITabelaRegrasDMSAppService _tabelaRegrasDMSAppService;

        public HomeController(ITabelaRegrasDMSAppService TabelaRegrasDMSAppService)
        {
            _tabelaRegrasDMSAppService = TabelaRegrasDMSAppService;
        }

        public ActionResult Index()
        {

            DadosIndexacaoViewModel model = new DadosIndexacaoViewModel();
            model.TipoDoc = new List<string>();


            var listarTipos = _tabelaRegrasDMSAppService.ObterTodos();

            foreach (var item in listarTipos)
            {
                model.TipoDoc.Add(item.DescricaoOutrosDocs);
            }




            return View(model);

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

        public void upload(DadosIndexacaoViewModel dadosIndexacaoViewModel)
        {
            string directory = @"C:\Temp\UploadIndexador\old\";
            //bool exists = Directory.Exists(Server.MapPath(directory));

            //if (!exists)
            //    Directory.CreateDirectory(Server.MapPath(directory));


            for (int i = 0; i < Request.Files.Keys.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);



                    file.SaveAs(Path.Combine(directory, fileName));
                }
            }

        }
    }
}