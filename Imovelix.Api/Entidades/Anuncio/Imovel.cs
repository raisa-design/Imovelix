using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovelix.Api.Entidades.Anuncio
{
    public class Imovel
    {
        public Guid Id { get; set; }
        public Endereco Endereco { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public int QuantQuartos { get; set; }
        public int Vagas { get; set; }
        public int QuantBanheiros { get; set; }

    }
}
