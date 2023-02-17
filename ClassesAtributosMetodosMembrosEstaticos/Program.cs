using System;
using System.Globalization;

namespace ClassesAtributosMetodosMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);

        }

    }

}