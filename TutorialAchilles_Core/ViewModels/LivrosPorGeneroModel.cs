using System.Collections.Generic;
using TutorialAchilles_Core.Models;

namespace TutorialAchilles_Core.ViewModels
{
    public class LivrosPorGeneroViewModel
    {
        public LivrosPorGeneroViewModel()
        {
            Genero = "Todos";
        }
        public string Genero { get; set; }
        public IList<Livro> Livros { get; set; }
    }
}