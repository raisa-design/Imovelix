namespace Imovelix.Api.Entidade
{
    public class Imovel
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Endereco { get; set; }

        public string Descricao { get; set; }

        public bool Disponivel { get; set; }

        public bool Status { get; set; }
    }
}
