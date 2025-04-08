using System;

namespace listaDeExercicio.Exercicio04
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double resultado = ((celsius * 9) / 5) + 32;

            Console.WriteLine($" A temperatura convertida para Fahrenheit é: {resultado}");
            Console.ReadLine();
        }
    }
}
