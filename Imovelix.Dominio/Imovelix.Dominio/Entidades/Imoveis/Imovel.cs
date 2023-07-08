namespace Imovelix.Dominio.Entidades.Imoveis
{
  public class Imovel
  {
    public Guid Id { get; set; }
    public string Endereco { get; set; }
    public int Quartos { get; set; }
    public double Preco { get; set; }
    public bool ParaAlugar { get; set; }

    public Imovel(string endereco, int quartos, double preco, bool paraAlugar)
    {
      Endereco = endereco;
      Quartos = quartos;
      Preco = preco;
      ParaAlugar = paraAlugar;
    }

    public void AtualizarPreco(double novoPreco)
    {
      Preco = novoPreco;
    }
  }
}
