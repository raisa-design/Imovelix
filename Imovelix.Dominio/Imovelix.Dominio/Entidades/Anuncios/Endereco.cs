using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovelix.Dominio.Entidades.Anuncios
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Referencia { get; set; }
    }
}
