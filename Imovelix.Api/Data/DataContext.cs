using Imovelix.Api.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Imovelix.Api.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }
    }
}
