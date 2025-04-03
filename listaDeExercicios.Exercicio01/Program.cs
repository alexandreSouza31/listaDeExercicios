namespace listaDeExercicios.Exercicio01
{
    internal class Program
    {
        //crie um app para calcular o volume de uma caixa retangular
        //volume=comprimento*largura*altura
        static void Main(string[] args)
        {
            #region input de dados
            Console.WriteLine("Digite o comprimento da caixa:");
            decimal comprimento=Convert.ToDecimal(Console.ReadLine()); 

            Console.WriteLine("Digite a largura da caixa:");
            decimal largura=Convert.ToDecimal(Console.ReadLine()); 
            
            Console.WriteLine("Digite a altura da caixa:");
            decimal altura=Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento de dados
            decimal resultado =comprimento * largura * altura;
            #endregion

            #region output de dados
            Console.WriteLine($"O volume da caixa é {resultado}");
            Console.ReadLine();
            #endregion
        }
    }
}
