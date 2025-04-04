namespace listaDeExercicios.Exercício06
{
    internal class Program
    {
        //6.Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da primeira prova: ");
            double primeiraProva = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a média da primeira prova: ");
            double mediaPrimeiraProva = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            double segundaProva = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a média da segunda prova: ");
            double mediaSedundaProva = Convert.ToDouble(Console.ReadLine());

            double resultado = ((primeiraProva * mediaPrimeiraProva)+(segundaProva * mediaSedundaProva))/(mediaPrimeiraProva+mediaSedundaProva);

            Console.WriteLine($"A média ponderada dos alunos é {resultado}");
            Console.ReadLine();
        }
    }
}