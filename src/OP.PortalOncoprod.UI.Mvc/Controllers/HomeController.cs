using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
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
            DadosIndexacaoViewModel model = ListarDocumentos();

            return View(model);
        }

        private DadosIndexacaoViewModel ListarDocumentos()
        {
            DadosIndexacaoViewModel model = new DadosIndexacaoViewModel();
            model.TipoDoc = new List<string>();


            var listarTipos = _tabelaRegrasDMSAppService.ObterTodos();

            foreach (var item in listarTipos)
            {
                model.TipoDoc.Add(item.DescricaoOutrosDocs);
            }

            return model;
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

        public void upload(DadosIndexacaoViewModel model)
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

            if (Request.Files.Keys.Count <= 0)
            {
                Listar();
            }
        }


        private void Listar()
        {
            DirectoryInfo Dir = new DirectoryInfo(@"C:\Temp\UploadIndexador\old\");
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                // Retira o diretório iformado inicialmente
                string FileName = File.FullName.Replace(Dir.FullName, "");
                //     SeuListBox.Items.Add(FileName);


                
            }
           
        }
    }
}