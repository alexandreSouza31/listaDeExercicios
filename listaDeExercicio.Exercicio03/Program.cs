namespace listaDeExercicio.Exercicio03
{
    internal class Program
    {
        //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.O
        //programa deve solicitar ao usuário:
        //● A quilometragem inicial do veículo no início da viagem.
        //● A quilometragem final ao término da viagem.
        //● A quantidade de combustível consumida durante a viagem(em litros).
        static void Main(string[] args)
        {
            Console.Write("Digite o km inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o km final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de cobustível: ");
            double qtdCombustivel = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Abs((kmInicial - kmFinal) / qtdCombustivel);

            Console.WriteLine($" O consumo de combustível por quilômetro percorrido é: {resultado}");
            Console.ReadLine();
        }
    }
}
