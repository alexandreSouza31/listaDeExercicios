namespace listaDeExercicios.Exercicio08
{
    //8. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para A: ");
            double valorDeA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para B: ");
            double valorDeB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para C: ");
            double valorDeC = Convert.ToDouble(Console.ReadLine());

            if(valorDeA + valorDeB < valorDeC)
            {
            Console.WriteLine($"A soma de A({valorDeA}) + B({valorDeB}) é menor que C ({valorDeC})");
            Console.ReadLine();

            }

        }
    }
}
