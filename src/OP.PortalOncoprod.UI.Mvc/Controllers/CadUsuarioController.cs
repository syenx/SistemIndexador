using SistemaIndexador.Application.Interfaces;
using SistemaIndexador.Application.ViewModels;
using SistemaIndexador.Domain.Interfaces.Repository;
using SistemaIndexador.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaIndexador.UI.Mvc.Controllers
{
    public class CadUsuarioController : Controller
    {

        private readonly IUsuarioAppService _usuarioApp;

        public CadUsuarioController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }


        public void RecarregarTabelaSelecionada(List<String> postData)
        {
            var teste = ViewData["NovoUsuario"];
        }

        // GET: CadUsuario
        public ActionResult Index()
        {

            

            var model = new UsuarioTabelaPrecoViewModel();
            List<GrupoSistemaTabelaPrecoViewModel> grupos = new List<GrupoSistemaTabelaPrecoViewModel>();
            GrupoSistemaTabelaPrecoViewModel grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 0,
                nomeGrupo = "Oncoprod RS"
            };
            grupos.Add(grupo);
            grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 1,
                nomeGrupo = "Norprod Fortaleza/CE"
            };
            grupos.Add(grupo);
            grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 2,
                nomeGrupo = "Hosplog DF"
            };
            grupos.Add(grupo);
            grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 3,
                nomeGrupo = "Oncoprod ES"
            };
            grupos.Add(grupo);
            grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 4,
                nomeGrupo = "TABELA CMED - P.F"
            };
            grupos.Add(grupo);
            grupo = new GrupoSistemaTabelaPrecoViewModel()
            {
                grupoId = 6,
                nomeGrupo = "TABELATABELA CMED - PMC"
            };
            grupos.Add(grupo);

            model.listaGrupo = grupos;

            return View(model);
        }

        // GET: CadUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadUsuario/Create
        public ActionResult Create(string buscar, int pageNumber = 1)
        {
            var paged = _usuarioApp.ObterTodos();
            ViewBag.TotalCount = Math.Ceiling((double)paged.Count / 5);
            ViewBag.PageNumber = pageNumber;
            ViewBag.SearchData = buscar;

            return View(paged.List);

        }

        public ActionResult ListaSelecionados(string buscar, int pageNumber = 1)
        {
            return PartialView();
        }

        // POST: CadUsuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadUsuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadUsuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
