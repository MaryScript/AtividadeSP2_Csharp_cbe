namespace Atividade
{
    class Clientes
{
  public string Nome { get; set; }
  public string Endereco { get; set; }
  public float Valor { get; protected set; }
  public float ValorImposto { get; protected set; }
  public float Total { get; protected set; }
public virtual void PagarImposto(float valor)
{
    this.Valor = valor;
    this.ValorImposto = this.Valor * 10 / 100;
    this.Total = this.Valor + this.ValorImposto;
}
}
}