namespace listaDeExercicios.Exercicio07
{
    internal class Program
    {
        //7. Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            Console.Write("Digite um número para saber se é primo: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());
            bool numeroEPrimo = true;

            if (numeroUsuario <= 1)
            {
                numeroEPrimo = false;
            }
            else
            {
                for (int i = 2; i < numeroUsuario; i++)
                {
                    if (numeroUsuario % i == 0)
                    {
                        numeroEPrimo = false;
                        break;
                    }
                }
            }

            if (numeroEPrimo)
            {
                Console.WriteLine($"Sim, o número {numeroUsuario} é primo!");
            }
            else
            {
                Console.WriteLine($"Não, o número {numeroUsuario} não é primo!");
            }

            Console.ReadLine();
        }
    }
}