namespace listaDeExercicios.Exercicio02
{
    internal class Program
    {
        //2. Crie um programa para calcular o volume de um Cilindro
        // V = PI .r2 . a
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do cilindro");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($" O raio do cilindro é: {raio}");
            Console.ReadLine();
        }
    }
}