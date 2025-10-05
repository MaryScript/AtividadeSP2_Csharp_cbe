namespace Atividade
{
    class PessoaJuridica : Clientes
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public override void PagarImposto (float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}