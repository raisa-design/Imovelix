using Imovelix.Dominio.Entidades.Imoveis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovelix.Infra.Config
{
  public class ImovelContext: DbContext
  {
    public ImovelContext(DbContextOptions<ImovelContext> options) : base(options) { }

    public DbSet<Imovel> Imoveis { get; set; }
  }
}
