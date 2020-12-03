using GerenciadorDeAnuncio.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeAnuncio.Context

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet <Anuncio> Anuncios { get; set; }
        public DbSet <Marca> Marcas { get; set; }
        public DbSet <Modelo> Modelos { get; set; }
    }
}
