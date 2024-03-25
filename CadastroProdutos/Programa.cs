
// Importa o namespace ProdutoDados para ter acesso à classe Produto
using ProdutoDados;

// Diretivas using para funcionalidades comumente usadas (não estritamente necessárias aqui)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    public static void Main(string[] args)
    {
        // Cria um novo objeto Produto
        Produto produto = new Produto();

        // Solicita ao usuário os detalhes do produto
        Console.WriteLine("Informe os dados do produto: ");

        Console.Write("Nome do Produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Preço do produto: ");
        string precoStr = Console.ReadLine();
        produto.Preco = double.Parse(precoStr);

        Console.Write("Quantidade em estoque: ");
        string quantidadeStr = Console.ReadLine();
        produto.QuantidadeEstoque = int.Parse(quantidadeStr);

        // Exibe os dados do produto
        Console.WriteLine(produto.ToString());
    }
}




