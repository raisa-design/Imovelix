
namespace Imovelix.Dominio.Entidades.Imoveis
{
   
    public class Imovel
    {
        public Guid Id { get; set; }
        public string Endereco { get; set; }
        public List<Quarto> Quartos { get; set; }
        public double Preco { get; set; }
        public bool ParaAlugar { get; set; }

        public Imovel()
        {

        }

        public void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }
    }
}
