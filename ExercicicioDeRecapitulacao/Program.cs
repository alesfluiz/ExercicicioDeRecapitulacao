using System;
using System.Globalization;

namespace exercicioDeRecapitulacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qts = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double nProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            String[] dados = Console.ReadLine().Split(' ');

            string uName = dados[0];
            int idade = int.Parse(dados[1]);
            double preco = double.Parse(dados[2], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(qts);
            Console.WriteLine(nProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(uName);
            Console.WriteLine(idade);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}