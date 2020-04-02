using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TutorialAchilles_Core.Models;
using TutorialAchilles_Core.ViewModels;

namespace TutorialAchilles_Core.Repositories
{
    public class LivroRepository : IRepository<Livro>
    {
        private Contexto _contexto;
        private IList<Livro> _livros;
        private IList<Genero> _generos;

        public LivroRepository(Contexto contexto)
        {
            _contexto  = contexto;
            _generos   = GetGeneros();
            _livros    = GetLivros();
        }

        public IList<Livro> GetAll()
        {
            return _livros;
        }

        public Livro GetById(int Id)
        {
            var cadastro = _livros.FirstOrDefault(x => x.Id == Id);
            return cadastro;
        }

        public List<LivroViewModel> GetListagem()
        {
            List<LivroViewModel> listagem = new List<LivroViewModel>();
            foreach (var item in _livros)
            {
                var itemListagem = new LivroViewModel
                {
                    Id        = item.Id.ToString(),
                    Titulo    = item.Titulo,
                    Autor     = item.Autor,
                    AnoEdicao = item.AnoEdicao.ToString(),
                    Valor     = item.Valor.ToString()
                };
                listagem.Add(itemListagem);
            }
            return listagem;
        }

        public IList<Genero> GetGeneros()
        {
            var resultado = _contexto.Generos.ToList();
            return resultado;
        }

        public IList<Livro> GetLivros()
        {
            var resultado = _contexto.Livros.ToList();
            return resultado;
        }

        public IList<string> GetForCombo(int opcao)
        {
            IList<string> resultado = new List<string>();
            switch (opcao)
            {
                case 1:
                    foreach (var item in _generos)
                        resultado.Add(item.Id.ToString() + "|" + item.Nome.ToUpper());
                    break;
                default:
                    break;
            }
            return resultado;
        }

        public int Save(Livro Livro)
        {
            int _resultado;
            try
            {
                if (Livro.Id == 0)
                {    _contexto.Livros.Add(Livro); }
                else
                {    _contexto.Entry(Livro).State = EntityState.Modified; }
                _resultado = _contexto.SaveChanges();
                _resultado = 1;
            }
            catch (Exception e)
            {
                _resultado = 0;
            }
            return _resultado;
        }

        public int Delete(int Id)
        {
            try
            {
                Livro Livro = _contexto.Livros.Find(Id);
                _contexto.Livros.Remove(Livro);
                int qtRegistrosAfetados = _contexto.SaveChanges();
                return qtRegistrosAfetados;
            }
            catch (Exception e)
            {
                string mensagemErro = e.Message;
                return 0;
            }
        }
    }
}