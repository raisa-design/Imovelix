namespace Imovelix.Api.Entidades.Anuncio
{
    public class Anuncio
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Fotos { get; set; }
        public Imovel Imovel { get; set; }
    }
}
