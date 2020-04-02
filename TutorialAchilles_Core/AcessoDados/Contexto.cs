using Microsoft.EntityFrameworkCore;
using TutorialAchilles_Core.Models;

namespace TutorialAchilles_Core.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TutorialAchilles_Core;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //optionsBuilder.UseSqlServer(conexao, providerOptions => providerOptions.CommandTimeout(30)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                optionsBuilder.UseSqlServer(conexao);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-35914");
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}