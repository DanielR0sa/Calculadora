using System;

namespace Calculadora01
{
    class CalculadoraCadastro
    {
        static void Main(string[] args)
        {
            string NomeCliente;

            String MoedaOrigem, MoedaDestino;

            double Valor1, Valor2, Resultado;


            Console.WriteLine("--------------------");
            Console.WriteLine("Digite seu nome:");
            Console.WriteLine("-------------------");
            NomeCliente = Console.ReadLine();

            Console.Clear();

       
            Console.WriteLine("---------------- OLÁ ------------------");
            Console.WriteLine(NomeCliente);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Digite o valor da moeda que deseja converter:");
            Console.WriteLine("------------------------------------------------");
            MoedaOrigem = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Neste momento digite o valor que deseja converter:");
            Console.WriteLine("------------------------------------------------");
            MoedaDestino = Console.ReadLine();


            DateTime DataOperação = DateTime.Now;

            Console.WriteLine(DataOperação);
        }
    }
}
