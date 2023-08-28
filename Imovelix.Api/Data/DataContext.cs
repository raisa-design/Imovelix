using Imovelix.Api.Entidades.Anuncio;
using Imovelix.Dominio.Entidades.Anuncios;
using Microsoft.EntityFrameworkCore;

namespace Imovelix.Api.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Imovel>()
        //        .HasMany(Q => new { PC.ProdutoId, PC.CategoriaId });


        //    modelBuilder.Entity<ItemPedido>()
        //        .HasKey(PC => new { PC.ProdutoId, PC.CompraId });

        //}
    }


}
