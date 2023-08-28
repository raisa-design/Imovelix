using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovelix.Dominio.Entidades.Imoveis
{
    public class Quarto
    {
        public Guid Id { get; set; }
        public double? TamanhoMetrosQuadrados { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeJanela { get; set; }

    }
}
