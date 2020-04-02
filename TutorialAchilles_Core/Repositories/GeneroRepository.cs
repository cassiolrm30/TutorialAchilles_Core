using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TutorialAchilles_Core.Models;
using TutorialAchilles_Core.ViewModels;

namespace TutorialAchilles_Core.Repositories
{
    public class GeneroRepository : IRepository<Genero>
    {
        private Contexto _contexto;
        private IList<Genero> _generos;

        public GeneroRepository(Contexto contexto)
        {
            _contexto = contexto;
            _generos = GetAll();
        }

        public IList<Genero> GetAll()
        {
            return _contexto.Generos.ToList();
        }

        public Genero GetById(int Id)
        {
            var cadastro = _contexto.Generos.FirstOrDefault(x => x.Id == Id);
            return cadastro;
        }

        public List<GeneroViewModel> GetListagem()
        {
            List<GeneroViewModel> listagem = new List<GeneroViewModel>();
            var generos = _contexto.Generos.ToList();
            foreach (var item in generos)
            {
                var itemListagem = new GeneroViewModel
                {
                    Id = item.Id.ToString(),
                    Nome = item.Nome
                };
                listagem.Add(itemListagem);
            }
            return listagem;
        }

        public int Save(Genero Genero)
        {
            int _resultado;
            try
            {
                if (Genero.Id == 0)
                { _contexto.Generos.Add(Genero); }
                else
                { _contexto.Entry(Genero).State = EntityState.Modified; }
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
                Genero Genero = _contexto.Generos.Find(Id);
                _contexto.Generos.Remove(Genero);
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