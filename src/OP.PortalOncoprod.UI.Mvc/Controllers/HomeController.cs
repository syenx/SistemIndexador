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
            model.ListaAquivos = ListarArquivosParaIndexar();

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

        }


        public void RenameArquivos(DadosIndexacaoViewModel model)
        {
            MoverERenomearArquivos();
        }


        private void MoverERenomearArquivos()
        {
            DirectoryInfo DirOld = new DirectoryInfo(@"C:\Temp\UploadIndexador\old\");
            string sourcePath = @"C:\Temp\UploadIndexador\old\";
            string targetPath = @"C:\Temp\UploadIndexador\new\";

            Directory.CreateDirectory(targetPath);

            FileInfo[] Files = DirOld.GetFiles("*", SearchOption.AllDirectories);


            foreach (FileInfo File in Files)
            {

                string FileName = File.FullName.Replace(DirOld.FullName, "");
                string sourceFile = Path.Combine(sourcePath, FileName);
                string destFile = Path.Combine(targetPath, FileName);

                System.IO.File.Copy(sourceFile, destFile, true);


                if (Directory.Exists(sourcePath))
                {
                    string[] files = Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        FileName = Path.GetFileName(s);
                        destFile = Path.Combine(targetPath, FileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
            }
        }


        private List<string> ListarArquivosParaIndexar()
        {

            DirectoryInfo DirOld = new DirectoryInfo(@"C:\Temp\UploadIndexador\new\");
            List<string> lista = new List<string>();


            FileInfo[] Files = DirOld.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                string FileName = File.FullName.Replace(DirOld.FullName, "");
                lista.Add(FileName);
            }

            return lista;

        }
    }
}