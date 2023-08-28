﻿using Imovelix.Api.Entidades.Anuncio;

namespace Imovelix.Api.ViewModels.Anuncio
{
    public class AnuncioEditarVm
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public int QuantQuartos { get; set; }
        public int Vagas { get; set; }
        public int QuantBanheiros { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }

    }
}
