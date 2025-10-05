using System;
namespace Atividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informar nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informar endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física(f) ou Jurídica(j)");
            string tipo = Console.ReadLine();

            if (tipo == "f")
            {
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = nome;
                pf.Endereco = endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine(); // Corrigido para 'cpf' minúsculo
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine(); // Corrigido para 'rg' minúsculo
                Console.WriteLine("Informar Valor:");

                // Correção Essencial 1: Ler o valor e passar para o método
                float valorInformado = float.Parse(Console.ReadLine());
                pf.PagarImposto(valorInformado);

                Console.WriteLine($"Nome: {pf.Nome}");
                Console.WriteLine($"Endereço: {pf.Endereco}");
                // Correção Essencial 2: Imprimir as propriedades corretas
                Console.WriteLine($"CPF: {pf.cpf}");
                Console.WriteLine($"RG: {pf.rg}");
                Console.WriteLine($"Valor de compra: {pf.Valor.ToString("C")}");
                Console.WriteLine($"Valor do imposto: {pf.ValorImposto.ToString("C")}");
                Console.WriteLine($"Valor total: {pf.Total.ToString("C")}");
            }
            else if (tipo == "j")
            {                                                                               
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = nome;
                pj.Endereco = endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Informar Inscrição Estadual:");
                pj.Ie = Console.ReadLine();
                Console.WriteLine("Informar Valor:");
                
                // Correção Essencial 1: Ler o valor e passar para o método
                float valorInformado = float.Parse(Console.ReadLine());
                pj.PagarImposto(valorInformado);

                Console.WriteLine($"Nome: {pj.Nome}");
                Console.WriteLine($"Endereço: {pj.Endereco}");
                Console.WriteLine($"CNPJ: {pj.Cnpj}");
                Console.WriteLine($"IE: {pj.Ie}");
                Console.WriteLine($"Valor de compra: {pj.Valor.ToString("C")}");
                Console.WriteLine($"Valor do imposto: {pj.ValorImposto.ToString("C")}");
                Console.WriteLine($"Valor total: {pj.Total.ToString("C")}");
            }
            // Correção Essencial 3: Estrutura do if-else
            else
            {
                Console.WriteLine("Valor informado de forma incorreta");
            }
        }
    }
}