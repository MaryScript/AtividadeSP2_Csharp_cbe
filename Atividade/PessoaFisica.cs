namespace Atividade
{ class PessoaFisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }
        public override void PagarImposto (float valor)
        {
            this.Valor = valor;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
        
}
    }