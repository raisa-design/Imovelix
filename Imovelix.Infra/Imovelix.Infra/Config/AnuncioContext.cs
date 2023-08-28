using Imovelix.Api.Entidades.Anuncio;
using Imovelix.Dominio.Entidades.Anuncios;
using Imovelix.Dominio.Entidades.Imoveis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovelix.Infra.Config
{
    public class AnuncioContext: DbContext
  {
    public AnuncioContext(DbContextOptions<AnuncioContext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
