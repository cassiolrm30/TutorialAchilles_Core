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
    public class LivroController : Controller
    {
        public LivroRepository _repositorio;

        public LivroController(LivroRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Listar(int paginaCorrente, int qtLinhas, string filtro, string ordenarPorCampo, string ordenarPorSentido)
        {
            //var livros = _repositorio.GetLivros().Join(_repositorio.GetGeneros(), livro => livro.GeneroId, genero => genero.Id, (livro, genero) => new { livro, genero })
            //            .Select(x => new
            //            {
            //                x.livro.Id,
            //                x.livro.Titulo,
            //                x.livro.Autor,
            //                x.livro.Valor,
            //                x.livro.AnoEdicao,
            //                x.genero.Nome
            //            }).ToList();
            IList<Livro> livros = new List<Livro>();
            var genero = new Genero(); genero.Id = 1; genero.Nome = "Teste de Genero";
            Livro livro;
            livro = new Livro(); livro.Genero = genero; livro.Id = 27; livro.Titulo = "1808"; livro.Autor = "Gomes. Laurentino"; livro.AnoEdicao = 2014; livro.Valor = 31.90M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 28; livro.Titulo = "A História do Mundo Para Quem Tem Pressa -Mais de 5000 Anos de História Resumidos Em 200 Páginas"; livro.Autor = "Marriot. Emma"; livro.AnoEdicao = 2015; livro.Valor = 22.60M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 9;  livro.Titulo = "A Origem Das Espécies - Edição Ilustrada"; livro.Autor = "Darwin. Charles"; livro.AnoEdicao = 2014; livro.Valor = 71.00M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 10; livro.Titulo = "A Sexta Extinção - Uma História Não Natural"; livro.Autor = "Kolbert. Elizabeth"; livro.AnoEdicao = 2015; livro.Valor = 17.00M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 3;  livro.Titulo = "Adestramento Inteligente"; livro.Autor = "Rossi. Alexandre"; livro.AnoEdicao = 2015; livro.Valor = 20.80M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 32; livro.Titulo = "Anatomia de Um Julgamento - Ifigênia Em Forest Hills"; livro.Autor = "Malcolm. Janet"; livro.AnoEdicao = 2012; livro.Valor = 22.40M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 4;  livro.Titulo = "Aves Florestais do Brasil"; livro.Autor = "Bini. Etson"; livro.AnoEdicao = 2014; livro.Valor = 89.90M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 6;  livro.Titulo = "Batman - A Morte da Família"; livro.Autor = "Capullo. Greg; Snyder. Scott"; livro.AnoEdicao = 2016; livro.Valor = 60.80M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 25; livro.Titulo = "Bela Cozinha - As Receitas"; livro.Autor = "Gil. Bela"; livro.AnoEdicao = 2014; livro.Valor = 29.10M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 12; livro.Titulo = "Cálculo"; livro.Autor = "Stewart. James"; livro.AnoEdicao = 2015; livro.Valor = 143.20M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 1;  livro.Titulo = "Título 1"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 413.99M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 2;  livro.Titulo = "Título 2"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 488.74M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 33; livro.Titulo = "Título 3"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 941.19M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 44; livro.Titulo = "Título 4"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 228.30M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 5;  livro.Titulo = "Título 5"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 808.13M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 6;  livro.Titulo = "Título 6"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 79.70M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 7;  livro.Titulo = "Título 7"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 976.36M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 88; livro.Titulo = "Título 8"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 582.41M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 91; livro.Titulo = "Título 9"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 201.96M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 99; livro.Titulo = "Título 10"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 702.54M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 11; livro.Titulo = "Título 11"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 941.99M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 42; livro.Titulo = "Título 12"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 432.15M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 13; livro.Titulo = "Título 13"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 228.40M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 14; livro.Titulo = "Título 14"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 28.16M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 15; livro.Titulo = "Título 15"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 270.92M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 16; livro.Titulo = "Título 16"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 313.82M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 17; livro.Titulo = "Título 17"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 163.30M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 18; livro.Titulo = "Título 18"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 69.30M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 19; livro.Titulo = "Título 19"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 721.38M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 20; livro.Titulo = "Título 20"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 909.80M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 21; livro.Titulo = "Título 21"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 755.74M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 22; livro.Titulo = "Título 22"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 156.11M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 23; livro.Titulo = "Título 23"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 908.50M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 24; livro.Titulo = "Título 24"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 914.19M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 55; livro.Titulo = "Título 25"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 357.34M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 26; livro.Titulo = "Título 26"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 787.47M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 77; livro.Titulo = "Título 27"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 15.92M; livros.Add(livro);
            livro = new Livro(); livro.Genero = genero; livro.Id = 81; livro.Titulo = "Título 28"; livro.Autor = "Matos. Cássio"; livro.AnoEdicao = 2020; livro.Valor = 522.96M; livros.Add(livro);
            int total = livros.Count();
            if (!String.IsNullOrWhiteSpace(filtro))
            {
                int ano = 0;
                int.TryParse(filtro, out ano);

                decimal valor = 0.0m;
                decimal.TryParse(filtro, out valor);

                livros = livros.Where(x => x.Titulo.Contains(filtro) || x.Autor.Contains(filtro) || x.AnoEdicao == ano || x.Valor == valor).ToList();
            }
            if (ordenarPorSentido.Equals("ASC"))
            {
                switch (ordenarPorCampo)
                {
                    case "Titulo":    livros = livros.OrderBy(x => x.Titulo).ToList();      break;
                    case "Autor":     livros = livros.OrderBy(x => x.Autor).ToList();       break;
                    case "Valor":     livros = livros.OrderBy(x => x.Valor).ToList();       break;
                    case "AnoEdicao": livros = livros.OrderBy(x => x.AnoEdicao).ToList();   break;
                }
            }
            else
            {
                switch (ordenarPorCampo)
                {
                    case "Titulo":    livros = livros.OrderByDescending(x => x.Titulo).ToList();    break;
                    case "Autor":     livros = livros.OrderByDescending(x => x.Autor).ToList();     break;
                    case "Valor":     livros = livros.OrderByDescending(x => x.Valor).ToList();     break;
                    case "AnoEdicao": livros = livros.OrderByDescending(x => x.AnoEdicao).ToList(); break;
                }
            }
            var livrosPaginados = livros.Skip((paginaCorrente - 1) * qtLinhas).Take(qtLinhas);
            return Json(new { rows = livrosPaginados.ToList(), total = total, current = paginaCorrente, rowCount = qtLinhas });
        }

        public ActionResult ListarPorGenero(int id)
        {
            LivrosPorGeneroViewModel livrosPorGeneroVM = new LivrosPorGeneroViewModel();
            IList<Livro> livros = _repositorio.GetLivros();
            if (id != 0)
            {
                IList<string> generos = _repositorio.GetForCombo(1);
                foreach (string genero in generos)
                {
                    string[] item = genero.Split('|');
                    if (int.Parse(item[0]) == id)
                    {
                        livrosPorGeneroVM.Genero = item[1];
                        break;
                    }
                }
                livros = livros.Where(l => l.GeneroId == id).ToList();
            }
            livrosPorGeneroVM.Livros = livros;
            return PartialView(livrosPorGeneroVM);
        }

        public IActionResult Cadastro(int id)
        {
            ViewBag.DadosCadastro = "";
            if (id != 0)
            {
                Livro cadastro = _repositorio.GetById(id);
                string resultado = "";
                resultado += cadastro.Id.ToString();
                resultado += "|" + cadastro.Titulo;
                resultado += "|" + cadastro.Autor.ToUpper();
                resultado += "|" + cadastro.Valor.ToString();
                resultado += "|" + cadastro.AnoEdicao.ToString();
                resultado += "|" + cadastro.GeneroId.ToString();
                ViewBag.DadosCadastro = resultado;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Salvar([FromBody]Livro cadastro)
        {
            if (ModelState.IsValid)
            {
                var resultado = _repositorio.Save(cadastro);
                return Json(new { resultado = true, mensagem = "Livro salvo com sucesso." });
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

        [HttpPost]
        public ActionResult Excluir(int Id)
        {
            var resultado = _repositorio.Delete(Id);
            return Json(new { resultado = true, mensagem = "Dados excluídos com sucesso." });
        }
    }
}