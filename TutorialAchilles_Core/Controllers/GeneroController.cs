using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using TutorialAchilles_Core.Models;
using TutorialAchilles_Core.Repositories;
using TutorialAchilles_Core.ViewModels;

namespace TutorialAchilles_Core.Controllers
{
    public class GeneroController : Controller
    {
        public GeneroRepository _repositorio;

        public GeneroController(GeneroRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Listar(ParametrosPaginacao parametrosPaginacao)
        {
            DadosFiltrados dadosFiltrados = FiltrarEPaginar(parametrosPaginacao);
            return Json(dadosFiltrados);
        }

        public DadosFiltrados FiltrarEPaginar(ParametrosPaginacao parametrosPaginacao)
        {
            var generos = _repositorio.GetAll().ToList();
            int total = generos.Count();
            if (!String.IsNullOrWhiteSpace(parametrosPaginacao.SearchPhrase))
                generos = generos.Where(x => x.Nome.Contains(parametrosPaginacao.SearchPhrase)).ToList();
            var generosPaginados = generos.OrderBy(x => x.Nome).Skip((parametrosPaginacao.Current - 1) * parametrosPaginacao.RowCount).Take(parametrosPaginacao.RowCount);
            DadosFiltrados dadosFiltrados = new DadosFiltrados()
            {
            };
            return dadosFiltrados;
        }

        public IActionResult Cadastro(int id)
        {
            ViewBag.DadosCadastro = "";
            if (id != 0)
            {
                Genero cadastro = _repositorio.GetById(id);
                string resultado = "";
                resultado += cadastro.Id.ToString();
                resultado += "|" + cadastro.Nome;
                ViewBag.DadosCadastro = resultado;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Salvar([FromBody]Genero cadastro)
        {
            if (ModelState.IsValid)
            {
                var resultado = _repositorio.Save(cadastro);
                return Json(new { resultado = true, mensagem = "Genero salvo com sucesso." });
            }
            else
            {
                IEnumerable<ModelError> erros = ModelState.Values.SelectMany(item => item.Errors);
                string mensagens = "";
                foreach (var item in erros)
                    mensagens = item.ErrorMessage + "<br>";
                return Json(new { resultado = false, mensagem = mensagens });
            }
        }

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult Excluir(int id)
        {
            try
            {
                var resultado = _repositorio.Delete(id);
                return Json(new { resultado = true, mensagem = "Genero excluído com sucesso." });
            }
            catch (Exception ex)
            {
                return Json(new { resultado = false, mensagem = ex.Message });
            }
        }
    }
}