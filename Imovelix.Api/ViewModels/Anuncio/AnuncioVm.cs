namespace Imovelix.Api.ViewModels.Anuncio
{
    public class AnuncioVm
    {
        public Guid AnuncioId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Fotos { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
        public int TipoImovel { get; set; }
        public int QuantQuartos { get; set; }
        public int Vagas { get; set; }
        public int QuantBanheiros { get; set; }
    }
}
