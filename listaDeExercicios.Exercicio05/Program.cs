namespace listaDeExercicios.Exercicio05
{
    internal class Program
    {
        //5.Crie um programa para calcular o salário total de um vendedor.Deverá ser informado o salário base e o total de
//vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            Console.Write("Digite o salário base: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o total de vendas: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão: ");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double resultado = salarioBase + ((totalVendas * comissao) / 100);

            Console.WriteLine($"O salário total é {resultado}");
            Console.ReadLine();
        }
    }
}

