



using System;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Xml;
namespace ProdutoDados { 
public class Produto
{
    private string nome;
    private double preco;
    private int quantidadeEstoque;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    public int QuantidadeEstoque
    {
        get { return quantidadeEstoque; }
        set { quantidadeEstoque = value; }
    }

    public double ValorTotalEstoque
    {
        get { return preco * quantidadeEstoque; }
    }

    public void AdicionarProduto(int quantidade)
    {
        if (quantidade < 0)
        {
            throw new ArgumentOutOfRangeException("Quantidade não pode ser negativa.");
        }

        quantidadeEstoque += quantidade;
    }

    public override string ToString()
    {
        return $"Nome: {nome}\nPreço: {preco:C2}\nQuantidade em estoque: {quantidadeEstoque}\nValor total em estoque: {ValorTotalEstoque:C2}";
    }
}
}